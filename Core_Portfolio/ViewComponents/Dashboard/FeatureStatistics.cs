using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.ViewComponents.Dashboard
{
	public class FeatureStatistics:ViewComponent
	{
		Context c = new Context();

		public IViewComponentResult Invoke()
		{
			ViewBag.v11 = c.Skills.Count();
			ViewBag.v12 = c.Messages.Where(x=>x.Status==false ).Count();
			ViewBag.v13 = c.Messages.Where(x => x.Status == true).Count();
			ViewBag.v14 = c.Experiences.Count();
			return View();
		}
	}
}
