
namespace Mind_Map.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;

        //Create Token
        private readonly IConfiguration _configuration;


        public AccountController(AppDbContext context, IPasswordHasher<User> passwordHasher, IConfiguration configuration)
        {
            _context = context;
            _passwordHasher = passwordHasher;
            _configuration = configuration;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterUser command)
        {var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == command.Email);
            if (existingUser != null)
            {
                return BadRequest(new { Message = "Email is already taken." });
            }
             var user = new User
            {
                Name = command.UserName,
                Email = command.Email,
                Age = command.Age,
                Gender = command.Gender
            };

            user.PasswordHash = _passwordHasher.HashPassword(user, command.Password);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(new { UserId = user.Id });
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUser command)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == command.Email);
            if (user == null)
            {
                return Unauthorized(new { Message = "Invalid email or password." });
            }

            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, command.Password);
            if (result == PasswordVerificationResult.Failed)
            {
                return Unauthorized(new { Message = "Invalid email or password." });
            }


            var jwtSettings = _configuration.GetSection("JWT");

            var claims = new[]
            {
    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
    new Claim(ClaimTypes.Email, user.Email),
    new Claim(ClaimTypes.Name, user.Name)
};

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["ExpiryMinutes"])),
                signingCredentials: creds
            );

            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new { Token = jwtToken });

        }

        [HttpPost("Change Password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePassword request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
            {
                return NotFound(new { Message = "User not found" });
            }

            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.OldPassword);
            if (result == PasswordVerificationResult.Failed)
            {
                return Unauthorized(new { Message = "Old password is incorrect" });
            }

            if (request.NewPassword != request.ConfirmNewPassword)
            {
                return BadRequest(new { Message = "New password and confirmation do not match" });
            }

            user.PasswordHash = _passwordHasher.HashPassword(user, request.NewPassword);

            await _context.SaveChangesAsync();

            return Ok(new { Message = "Password changed successfully" });
        }

        [HttpPost("Change Email")]
        public async Task<IActionResult> ChangeEmail([FromBody] ChangeEmail request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.CurrentEmail);
            if (user == null)
            {
                return NotFound(new { Message = "User not found." });
            }

            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);
            if (result == PasswordVerificationResult.Failed)
            {
                return Unauthorized(new { Message = "Incorrect password." });
            }

            var existingUserWithNewEmail = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.NewEmail);
            if (existingUserWithNewEmail != null)
            {
                return BadRequest(new { Message = "Email is already in use." });
            }

            user.Email = request.NewEmail;

            await _context.SaveChangesAsync();

            return Ok(new { Message = "Email updated successfully." });
        }
    

    [HttpPost("ChangeUserName")]
        public async Task<IActionResult> ChangeUserName([FromBody] ChangeUserName request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
            {
                return NotFound(new { Message = "User not found." });
            }

            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);
            if (result == PasswordVerificationResult.Failed)
            {
                return Unauthorized(new { Message = "Incorrect password." });
            }

            user.Name = request.NewUserName;
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Username updated successfully." });
        }

    }
}



