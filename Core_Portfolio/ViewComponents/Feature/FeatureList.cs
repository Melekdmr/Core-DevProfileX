using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.ViewComponents.Feature
{
	public class FeatureList:ViewComponent
	{
		FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
		public IViewComponentResult Invoke()
		{
			var values = featureManager.Getlist();
			return View(values);
		}
	}
}
