using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class ServiceController : Controller
	{
		
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
		public IActionResult Index()
		{
			ViewBag.v1 = "Hizmet Listesi";
			ViewBag.v2 = "Hizmetler";
			ViewBag.v3 = "Hizmet Listesi";
			var values = serviceManager.Getlist();
			return View(values);
		}
	}
}
