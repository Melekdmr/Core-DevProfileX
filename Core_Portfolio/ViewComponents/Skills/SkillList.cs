using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;



namespace Core_Portfolio.ViewComponents.Skills
{
	public class SkillList :ViewComponent
	{
		SkillManager skillManager = new SkillManager(new EfSkillDal());
		public IViewComponentResult Invoke()
		{
			var values = skillManager.Getlist();
			return View(values);
		}
	}
}
