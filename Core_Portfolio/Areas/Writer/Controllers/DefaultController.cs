using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Authorize]
	public class DefaultController : Controller
	{
		AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
		public IActionResult Index()
		{
			var values = announcementManager.Getlist();
			return View(values);
		}
	}
}
