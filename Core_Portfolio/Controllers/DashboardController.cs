using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{

		
			return View();
		}
	}
}
