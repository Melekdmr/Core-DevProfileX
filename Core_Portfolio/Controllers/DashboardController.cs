using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	[Authorize(Roles = "Admin")]
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{

		
			return View();
		}
	}
}
