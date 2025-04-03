using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class AdminMessageController : Controller
	{
		WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
		public IActionResult ReceiverMessageList()
		{
			string p = "admin@gmail.com";
			var values = writerMessageManager.GetListReceiverMessage(p);
			return View(values);
		}
		public IActionResult SendMessageList()
		{
			string p = "admin@gmail.com";
			var values = writerMessageManager.GetListSenderMessage(p);
			return View(values);
		}
		public IActionResult AdminMessageDetails(int id)
		{
			var values = writerMessageManager.TGetByID(id);
			return View(values);
		}
		public IActionResult AdminMessageDelete(int id)
		{
			var values = writerMessageManager.TGetByID(id);
			writerMessageManager.TDelete(values);
			return RedirectToAction("SendMessageList");
		}
		[HttpGet]
		public IActionResult AdminMessageSend()
		{

			return View();

		}
		[HttpPost]
		public IActionResult AdminMessageSend(WriterMessage p)
		{
			p.Sender = "admin@gmail.com";
			p.SenderName = "Admin";
			
			p.Date = DateTime.Now.Date;
			Context c = new Context();
			var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
			p.ReceiverName = usernamesurname;
			writerMessageManager.TAdd(p);
			return RedirectToAction("SendMessageList");
		}
	}
}
