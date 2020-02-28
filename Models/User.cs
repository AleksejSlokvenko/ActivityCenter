using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = " is required. Please enter yuor name.")]
        [MinLength(2, ErrorMessage = " must be at least 2 characters long.")]
        public string Name { get; set; }

        [Required(ErrorMessage = " is required. Please enter yuor email.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = " is required. Please enter yuor password.")]
        [MinLength(8, ErrorMessage = " must be at least 8 characters!")]
        [RegularExpression("^(?=.*?[A-Za-z])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = " must contain  upper, lowercase and special characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        public List<Occasion> Activities { get; set; }
    }
     public class LoginUser
    {
        [Required(ErrorMessage = " is required to login.")]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = " is required to login.")]
        [MinLength(8, ErrorMessage = " must be 8 characters or longer!")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }

    }
}