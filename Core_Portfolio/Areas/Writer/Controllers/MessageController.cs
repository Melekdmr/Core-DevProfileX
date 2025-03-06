using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Areas.Writer.Controllers
{
	[Area("Writer")]
	public class MessageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
