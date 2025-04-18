﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace Core_Portfolio.Controllers
{
	[Authorize(Roles ="Admin")] //Bu sayfaya sadece rolü admin olan kullanıcılar erişebilir.
	public class ExperienceController : Controller
	{
		ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
		public IActionResult Index()
		{
			var values = experienceManager.Getlist();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddExperience()
		{
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
			var values = experienceManager.TGetByID(id);

			return View(values);

		}
		[HttpPost]
		public IActionResult EditExperience(Experience experience)
		{

			

			experienceManager.TUpdate(experience);

			return RedirectToAction("Index");
		}
	}
}


