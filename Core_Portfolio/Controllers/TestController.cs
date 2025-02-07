using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class TestController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
