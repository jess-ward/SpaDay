using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username required!")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required!")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters!")]
        [Compare("VerifyPassword", ErrorMessage = "Passwords do not match!")]
        [RegularExpression("(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password must be verified!")]
        public string VerifyPassword { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }

}
