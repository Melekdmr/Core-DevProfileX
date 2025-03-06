using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Areas.Writer.ViewComponents
{
	public class Notification:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
