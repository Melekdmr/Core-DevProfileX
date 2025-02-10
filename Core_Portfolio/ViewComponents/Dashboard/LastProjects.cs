using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.ViewComponents.Dashboard
{
	public class LastProjects:ViewComponent  
	{
		
		public IViewComponentResult Invoke()
		{
		
			return View();
		}
	
	}
}
