using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class DefaultController1 : Controller
	{
		public IActionResult Index()  // IActionResult came in interface format
		{
			return View();
		}
	}
}
