using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.ViewComponents.Service
{
	public class ServiceList : ViewComponent
	{
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
		public IViewComponentResult Invoke()
		{
			var values = serviceManager.Getlist();
			return View(values);
		}
	}
}

