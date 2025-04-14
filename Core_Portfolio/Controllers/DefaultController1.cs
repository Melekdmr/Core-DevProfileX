using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	[AllowAnonymous]
	public class DefaultController1 : Controller
	{
		public IActionResult Index()  // IActionResult came in interface format
		{
			return View();
		}
		 public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}
		public  PartialViewResult NavBarPartial()
		{
			return PartialView();
		}
		[HttpGet]
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult SendMessage(Message p)
		{
			MessageManager messageManager = new MessageManager(new EfMessageDal());

			p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			p.Status = true;
			messageManager.TAdd(p);
			
			return PartialView();
		}
	}
}
