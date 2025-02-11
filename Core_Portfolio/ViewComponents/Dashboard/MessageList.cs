using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.ViewComponents.Dashboard
{
	public class MessageList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			

			return View();
		}
	}
}
