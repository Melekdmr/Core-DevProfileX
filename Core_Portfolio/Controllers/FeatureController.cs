using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class FeatureController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
