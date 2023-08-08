using System;
using System.ComponentModel.DataAnnotations;

namespace Business.ViewModels.User.Account
{
    public class AccountRegisterVM
    {
        [Required]
        public string Username { get; set; }

        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}

