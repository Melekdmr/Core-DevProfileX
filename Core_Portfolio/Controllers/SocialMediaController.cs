using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace Core_Portfolio.Controllers
{
	public class SocialMediaController : Controller
	{
		SocialMediaManager sociaMediaManager = new SocialMediaManager(new EfSocialMediaDal());
		public IActionResult Index()
		{
			var values = sociaMediaManager.Getlist();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddSocialMedia()
		{

			ViewBag.StatusList = new SelectList(new List<SelectListItem>
		{
			new SelectListItem { Text = "Aktif", Value = "true" },
			new SelectListItem { Text = "Pasif", Value = "false" }
		}, "Value", "Text");

			return View();
		}
		[HttpPost]
		public IActionResult AddSocialMedia(SocialMedia p)
		{
			sociaMediaManager.TAdd(p);
			return RedirectToAction("Index");
		}

		public IActionResult DeleteSocialMedia(int id)
		{
			var values = sociaMediaManager.TGetByID(id);
			sociaMediaManager.TDelete(values);
			return RedirectToAction("Index");

		}
		[HttpGet]
		public IActionResult EditSocialMedia(int id)
		{
			var values = sociaMediaManager.TGetByID(id);

			// Durumlar için aktif/pasif seçeneklerini listeliyoruz
			ViewBag.StatusList = new SelectList(new List<SelectListItem>
	    {
		new SelectListItem { Text = "Aktif", Value = "true" },
	 	new SelectListItem { Text = "Pasif", Value = "false" }
	   }, "Value", "Text", values.Status.ToString());
   
			return View(values);

		}
		[HttpPost]
		public IActionResult EditSocialMedia(SocialMedia p)
		{
			sociaMediaManager.TUpdate(p);
			return RedirectToAction("Index");
		}

	}
}
