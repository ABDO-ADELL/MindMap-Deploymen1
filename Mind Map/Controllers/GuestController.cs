// GuestController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Mind_Map.Models;
//using Mind_Map.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Mind_Map.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public GuestController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("guest_login")]
        public async Task<IActionResult> GuestLogin()
        {
            try
            {
                // Create a very simple guest user with minimum required fields
                var guestUser = new User
                {
                    Name = "Guest User",
                    Email = "guest@example.com",
                    UserName = "Guest_" + DateTime.Now.Ticks,
                    PasswordHash = "guest_placeholder_hash", // Skip BCrypt for now to isolate the issue
                    Age = 0,
                    IsEmailVerified = true,
                    CreatedAt = DateTime.UtcNow,
                    IsGuest = true
                };

                // Add to database
                _context.Users.Add(guestUser);
                await _context.SaveChangesAsync();

                // Generate JWT token
                var token = GenerateJwtToken(guestUser);

                return Ok(new
                {
                    success = true,
                    message = "Guest login successful",
                    token,
                    user = new
                    {
                        id = guestUser.Id,
                        username = guestUser.UserName,
                        isGuest = true
                    }
                });
            }
            catch (Exception ex)
            {
                // Return full exception details for debugging
                return StatusCode(500, new
                {
                    success = false,
                    message = "Failed to create guest account",
                    error = ex.ToString() // Full exception details
                });
            }
        }
        [HttpPost("convert_guest")]
        public async Task<IActionResult> ConvertGuest([FromBody] ConvertGuestRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Get user ID from token claims
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized(new
                    {
                        success = false,
                        message = "User not authenticated"
                    });
                }

                // Find the guest user
                var user = await _context.Users.FindAsync(userId);
                if (user == null)
                {
                    return NotFound(new
                    {
                        success = false,
                        message = "User not found"
                    });
                }

                // Verify this is a guest account
                if (!user.IsGuest)
                {
                    return BadRequest(new
                    {
                        success = false,
                        message = "Only guest accounts can be converted"
                    });
                }

                // Update user information
                user.UserName = request.Username;
                user.Email = request.Email;
                user.PasswordHash = HashPassword(request.Password); // Using BCrypt 
                user.IsGuest = false;

                await _context.SaveChangesAsync();

                // Generate new token with updated information
                var token = GenerateJwtToken(user);

                return Ok(new
                {
                    success = true,
                    message = "Guest account successfully converted",
                    token,
                    user = new
                    {
                        id = user.Id,
                        username = user.UserName,
                        email = user.Email,
                        isGuest = false
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = "Failed to convert guest account",
                    error = ex.Message
                });
            }
        }

        private string GenerateJwtToken(User user)
        {
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new Claim(ClaimTypes.Name, user.UserName),
        new Claim("IsGuest", user.IsGuest.ToString()),
    };

            var secretKey = _configuration["JWT:SecretKey"];
            if (string.IsNullOrEmpty(secretKey))
            {
                throw new Exception("JWT SecretKey is missing in configuration.");
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.UtcNow.AddDays(user.IsGuest ? 1 : 7); // Shorter expiration for guests

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                claims: claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private string HashPassword(string password) 
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }

    public class ConvertGuestRequest
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}