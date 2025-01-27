using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.ViewComponents.About
{
	public class AboutList:ViewComponent  
	{
		AboutManager aboutManager = new AboutManager(new EfAboutDal());
		public IViewComponentResult Invoke()
		{
			var values = aboutManager.Getlist();
			return View(values);
		}
	}
}
