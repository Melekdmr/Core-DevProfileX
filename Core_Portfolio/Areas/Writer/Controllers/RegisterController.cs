using Core_Portfolio.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Areas.Writer.Controllers
{
	[Area("Writer")]
	public class RegisterController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(UserRegisterViewModel p)
		{
			if (ModelState.IsValid)
			{
				
			}
			return View();
		}

	}
}
