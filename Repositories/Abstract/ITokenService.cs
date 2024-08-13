using System;
using System.Security.Claims;
using loginAPI.Models.DTO;

namespace loginAPI.Repositories.Abstract
{
	public interface ITokenService
	{
		TokenResponse GetToken(IEnumerable<Claim> claim);

		string GetRefreshToken();

		ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
	}
}

