using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Mind_Map.Models
{
    public class User : IdentityUser
    {
        // Remove Id, Email, PasswordHash, and UserName as they're already in IdentityUser
        public string Name { get; set; }

        public int Id { get; set; }

        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? PersonalityType { get; set; }
        public List<Assessment>? Assessments { get; set; } = new List<Assessment>();
        public string? EmailVerificationToken { get; set; }
        public bool IsEmailVerified { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public bool IsGuest { get; set; }
    }
}
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Email { get; set; }
//        public string PasswordHash { get; set; }
//        public int Age { get; set; }
//        public string? Gender { get; set; }

//        public string? PersonalityType { get; set; }
//        public List<Assessment>? Assessments { get; set; } = new List<Assessment>();

//        public string? EmailVerificationToken { get; set; }
//        public bool IsEmailVerified { get; set; } = false;

//        public DateTime CreatedAt { get; set; }
//        public string UserName { get; set; }
//        public bool IsGuest { get; set; }