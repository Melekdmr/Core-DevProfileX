using Core_Portfolio.Areas.Writer.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Core_Portfolio.Areas.Writer.Controllers
{
	[Area("Writer")]
	public class DashboardController : Controller
	{
	
		private readonly UserManager<WriterUser> _userManager;

		public DashboardController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task< IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel model = new UserEditViewModel();
			ViewBag.v = values.Name + " " + values.Surname;

			//Weather Api
			
			string api = "917f65ac37cdc9b4105cae703cf11769";
			string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
			XDocument document = XDocument.Load(connection);
			ViewBag.v5 = document.Descendants("feels_like").ElementAt(0).Attribute("value").Value;



			//statistics
			Context c = new Context();
			ViewBag.v1 = 0;
			ViewBag.v2 = c.Announcements.Count();
			ViewBag.v3 = 0;
			ViewBag.v4 = c.Services.Count();

			return View();
		}
	}
}
