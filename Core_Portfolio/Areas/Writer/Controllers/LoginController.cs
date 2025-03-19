using Core_Portfolio.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Route("Writer/[controller]/[action]")]
	public class LoginController : Controller
	{
		private readonly SignInManager<WriterUser> _signInManager;

		//Generic Constructor
		public LoginController(SignInManager<WriterUser> signInManager)
		{
			_signInManager = signInManager;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserLoginViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
				if (result.Succeeded)
				{
					//RedirectToAction kullanıldığında, ASP.NET Core yalnızca mevcut "area" içinde
					//controller arar (eğer bir area içindeyseniz).
					return RedirectToAction("Index","Dashboard");


				}
				else
				{
					ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
				}
			}return View();
		}
	}
}
