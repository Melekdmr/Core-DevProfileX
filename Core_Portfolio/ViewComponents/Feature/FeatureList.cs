using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.ViewComponents.Feature
{
	public class FeatureList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
