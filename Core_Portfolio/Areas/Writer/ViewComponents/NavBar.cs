using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Areas.Writer.ViewComponents
{
	public class NavBar:ViewComponent
	{
		private readonly UserManager<WriterUser> _userManager;

		public NavBar(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.v = values.ImageUrl;
			return View();
		}
	}
}
