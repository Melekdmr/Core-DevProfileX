using Core_Portfolio.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Security.Principal;

namespace Core_Portfolio.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Route("Writer/[controller]/[action]")]
	public class RegisterController : Controller
	/* UserManager<WriterUser> gibi bağımlılıklar (service, repository, database context vb.)
	 * doğrudan new anahtar kelimesiyle oluşturulmaz.Bunun yerine, constructor içinde 
	 * dışarıdan enjekte edilir. */
	{
		/*readonly anahtar kelimesi, bu değişkenin yalnızca yapıcı metod (constructor) içinde değer alabileceğini belirtir.*/
		private readonly UserManager<WriterUser> _userManager;

		//constructor ataması yapıldı.

		/*Bu satırda, UserManager<WriterUser> türünde bir değişken tanımlanıyor.UserManager sınıfı,
		 * ASP.NET Core Identity sisteminin kullanıcı yönetimi işlemlerini gerçekleştirir. */
		public RegisterController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserRegisterViewModel p)
		{
			
				WriterUser w = new WriterUser()
				{
					Name = p.Name,
					Surname = p.Surname,
					Email = p.Mail,
					UserName = p.UserName,
					ImageUrl = p.ImageUrl

				};
			if (p.Password == p.ConfirmPassword)
			{
				var result = await _userManager.CreateAsync(w, p.Password);

		
			
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Login");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}

			}

			return View(p);
		}
	}
}

