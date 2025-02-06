using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
		[HttpGet]
		public IActionResult AddService()
		{
			ViewBag.v1 = "Yetenek Ekleme";
			ViewBag.v2 = "Yetenekler";
			ViewBag.v3 = "Yetenek Ekleme";
			return View();

		}
		[HttpPost]
		public IActionResult AddService(Service service)
		{
			serviceManager.TAdd(service);

			return RedirectToAction("Index");
		}

		public IActionResult DeleteService(int id)
		{
			var values = serviceManager.TGetByID(id);
			serviceManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditService(int id)
		{
			ViewBag.v1 = "Düzenleme";
			ViewBag.v2 = "Yetenekler";
			ViewBag.v3 = "Yetenek Güncelleme";
			var values = serviceManager.TGetByID(id);

			return View(values);

		}
		[HttpPost]
		public IActionResult EditService(Service service)
		{

			ViewBag.v1 = "Düzenleme";
			ViewBag.v2 = "Yetenekler";
			ViewBag.v3 = "Yetenek Güncelleme";

			serviceManager.TUpdate(service);

			return RedirectToAction("Index");
		}
	}
}

