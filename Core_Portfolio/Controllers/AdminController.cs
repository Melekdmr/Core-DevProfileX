using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class AdminController : Controller
	{
		public PartialViewResult PartialSideBar()
		{
			return PartialView();
		}
		public PartialViewResult PartialFooter()
		{
			return PartialView();
		}
		public PartialViewResult PartialNavBar()
		{
			return PartialView();
		}
		public PartialViewResult PartialHead()
		{
			return PartialView();
		}
		public PartialViewResult PartialScripts()
		{
			return PartialView();
		}
		public PartialViewResult PartialNavigation()
		{
			return PartialView();
		}
		public PartialViewResult NewSideBar()
		{
			return PartialView();
		}

	}
}