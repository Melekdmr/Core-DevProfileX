using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.ViewComponents.Dashboard
{
	public class MessageList:ViewComponent
	{
		MessageManager messageManager = new MessageManager(new EfMessageDal());
		public IViewComponentResult Invoke()
		{

			var values = messageManager.Getlist().Take(5).ToList();


			return View(values);
		}
	}
}
