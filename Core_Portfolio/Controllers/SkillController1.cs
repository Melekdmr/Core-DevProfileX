using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class SkillController1 : Controller
	{

		SkillManager skillManager = new SkillManager(new EfSkillDal());
		public IActionResult Index()
		{
			var values = skillManager.Getlist();

			return View(values);
		}
	}
}
