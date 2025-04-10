using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core_Portfolio.ViewComponents.Dashboard
{
	
	public class AdminNavbarMessageList:ViewComponent
	{
		WriterMessageManager writerMessage = new WriterMessageManager(new EfWriterMessageDal());
		public IViewComponentResult Invoke()
		{
			 Context c = new Context();
			string p = "admin@gmail.com";
			var values = writerMessage.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageID).Take(3).ToList();

			foreach (var item in values)
			{
				// Eğer ImageUrl null ise Users tablosundan alıyoruz
				if (string.IsNullOrEmpty(item.ImageUrl))
				{
					item.ImageUrl = c.Users.Where(x => x.Email == item.Sender)
									 .Select(x => x.ImageUrl)
									 .FirstOrDefault() ?? "/corona-free/dist/assets/images/faces/default.jpg";
				}
			}




			return View(values);

		}
	}
}
