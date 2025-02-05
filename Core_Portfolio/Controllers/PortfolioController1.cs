using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Controllers
{
	public class PortfolioController1 : Controller
	{
		PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

		public IActionResult Index()
		{
			ViewBag.v1 = "Proje Listesi";
			ViewBag.v2 = "Projelerim";
			ViewBag.v3 = "Proje Listesi";
			var values = portfolioManager.Getlist();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddPortfolio()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddPortfolio(Portfolio portfolio)
		{
			portfolio.ImageUrl = portfolio.ImageUrl ?? "/Template/images/portfolio/P1.png";
			portfolio.ImageUrl2 = portfolio.ImageUrl2 ?? "/Template/images/portfolio/P1.png"; // Eğer boş bir değer ise sağdaki yol gönderilir.

			portfolio.image2 = portfolio.image2 ?? "/Template/images/portfolio/P1.png";
			
			portfolio.image3 = portfolio.image3 ?? "/Template/images/portfolio/P1.png";

			portfolio.Value = portfolio.Value == 0 ? 0 : portfolio.Value;




			ViewBag.v1 = "Proje Listesi";
			ViewBag.v2 = "Projelerim";
			ViewBag.v3 = "Proje Ekleme";
			portfolioManager.TAdd(portfolio);
			return RedirectToAction("Index");
		}
	}
}
