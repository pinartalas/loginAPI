using System;
using Microsoft.AspNetCore.Identity;

namespace loginAPI.Models.Domain
{
	public class ApplicationUser : IdentityUser
	{
		public string? Name { get; set; }

	}
}

