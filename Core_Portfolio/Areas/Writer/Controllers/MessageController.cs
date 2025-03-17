using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Areas.Writer.Controllers
{
	[Area("Writer")]
	public class MessageController : Controller
	{

		
		WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

		private readonly UserManager<WriterUser> _userManager;

		public MessageController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IActionResult > ReceiverMessage(string p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;
			var messageList = writerMessageManager.GetListReceiverMessage(p);
			return View(messageList);
		}

		public async Task<IActionResult> SenderMessage(string p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;
			var messageList = writerMessageManager.GetListSenderMessage(p);
			return View(messageList);
		}
		[HttpGet]
		public IActionResult MessageDetails(int id)
		{
			WriterMessage writerMessage= writerMessageManager.TGetByID(id);
			return View(writerMessage);
		}
	}
}
