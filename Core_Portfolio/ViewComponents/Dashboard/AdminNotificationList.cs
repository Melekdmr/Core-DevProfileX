using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.ViewComponents.Dashboard
{
	public class AdminNotificationList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
