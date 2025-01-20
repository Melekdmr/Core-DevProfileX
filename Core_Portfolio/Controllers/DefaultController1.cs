using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class DefaultController1 : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
