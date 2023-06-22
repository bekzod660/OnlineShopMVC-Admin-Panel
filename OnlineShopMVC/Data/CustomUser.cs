using Microsoft.AspNetCore.Identity;

namespace OnlineShopMVC.Data
{
	public class CustomUser : IdentityUser
	{
		public string? Picture { get; set; }

	}
}