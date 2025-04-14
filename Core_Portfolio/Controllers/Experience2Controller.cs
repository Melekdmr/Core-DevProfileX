using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Portfolio.Controllers
{
	public class Experience2Controller : Controller
	{
		ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
		
		public IActionResult Index()
		{

			return View();
		}
		public IActionResult ListExperience()
		{
			var values = JsonConvert.SerializeObject(experienceManager.Getlist());

			return Json(values);
		}
		[HttpPost]
		public IActionResult AddExperience(Experience p)
		{
			//Eğer ImageUrl boşsa, varsayılan bir değer ata
             if (string.IsNullOrEmpty(p.ImageUrl))
			{
				p.ImageUrl = "default-image.jpg";
			}
			// Varsayılan bir resim URL'si
			// Eğer Description boşsa, varsayılan bir açıklama ata
			if (string.IsNullOrEmpty(p.Deccription))
			{
				p.Deccription = "Açıklama eklenmedi.";
			}
			if (string.IsNullOrEmpty(p.company))
			{
				p.company= "sirket.";
			}
		
			experienceManager.TAdd(p);
			var values = JsonConvert.SerializeObject(p);
			return Json(values);
		}
		public IActionResult GetById(int ExperienceId)
		{
			var v = experienceManager.TGetByID(ExperienceId);

			var values = JsonConvert.SerializeObject(v);
			return Json(values);
		}
		public IActionResult DeleteExperience(int id)
		{
			var v = experienceManager.TGetByID(id);
			experienceManager.TDelete(v);
			return NoContent();
		}

	}
}

