using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class AdminController : Controller
	{
		public PartialViewResult PartialSideBar()
		{
			return PartialView();
		}
	}
}
