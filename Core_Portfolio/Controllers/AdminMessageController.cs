using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
			return RedirectToAction("SenderMesageList");
		}
	}
}
