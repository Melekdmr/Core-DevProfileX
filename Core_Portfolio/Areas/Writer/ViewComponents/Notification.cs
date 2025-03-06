using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Areas.Writer.ViewComponents
{
	public class Notification:ViewComponent
	{
		AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
		public IViewComponentResult Invoke()
		{
			var values = announcementManager.Getlist();
			return View(values);
		}
	}
}
