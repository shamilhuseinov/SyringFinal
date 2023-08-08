using System;
using System.ComponentModel.DataAnnotations;

namespace Business.ViewModels.User.Account
{
	public class AccountLoginVM
	{
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

