using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
