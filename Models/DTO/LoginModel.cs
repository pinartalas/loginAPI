using System;
using System.ComponentModel.DataAnnotations;

namespace loginAPI.Models.Domain
{
	public class LoginModel
	{
		[Required]
		public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

	}
}

