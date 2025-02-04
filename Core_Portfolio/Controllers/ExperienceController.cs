using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;

namespace Core_Portfolio.Controllers
{
	public class ExperienceController : Controller
	{
		ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
		public IActionResult Index()
		{
			ViewBag.v1 = "Deneyim Listesi";
			ViewBag.v2 = "Deneyimler";
			ViewBag.v3 = "Deneyim Listesi";
			var values = experienceManager.Getlist();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddExperience()
		{
			ViewBag.v1 = "Deneyim Ekleme";
			ViewBag.v2 = "Deneyimler";
			ViewBag.v3 = "Deneyim Ekleme";
			return View();
		}
		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
			experienceManager.TAdd(experience);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteExperience(int id)
		{
			var values = experienceManager.TGetByID(id);
			experienceManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditExperience(int id)
		{
			ViewBag.v1 = "Düzenleme";
			ViewBag.v2 = "Deneyimler";
			ViewBag.v3 = "Deneyim Güncelleme";
			var values = experienceManager.TGetByID(id);

			return View(values);

		}
		[HttpPost]
		public IActionResult EditExperience(Experience experience)
		{

			ViewBag.v1 = "Düzenleme";
			ViewBag.v2 = "Yetenekler";
			ViewBag.v3 = "Yetenek Güncelleme";

			experienceManager.TUpdate(experience);

			return RedirectToAction("Index");
		}
	}
}


