using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.ViewComponents.Dashboard
{
	public class VisitorMap:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}
