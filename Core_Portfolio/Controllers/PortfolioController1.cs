using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using ValidationResult = FluentValidation.Results.ValidationResult;

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
			ViewBag.v1 = "Proje Listesi";
			ViewBag.v2 = "Projelerim";
			ViewBag.v3 = "Proje Ekleme";
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

			PortfolioValidator validations = new PortfolioValidator();
			ValidationResult result = validations.Validate(portfolio);//kuralın geçerliliğini kontrol eder
			if(result.IsValid)
			{
				portfolioManager.TAdd(portfolio);
				return RedirectToAction("Index");
			}
			else
			{
				foreach(var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
				}
			}
			return View();
		
			
		
		}
		public IActionResult DeletePortfolio(int id)
		{
			var values = portfolioManager.TGetByID(id);
			portfolioManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditPortfolio(int id)
		{
			ViewBag.v1 = "Proje Listesi";
			ViewBag.v2 = "Projelerim";
			ViewBag.v3 = "Proje Düzenleme";
			var values = portfolioManager.TGetByID(id);

			return View(values);

		}
		[HttpPost]
		public IActionResult EditPortfolio(Portfolio portfolio)
		{

			PortfolioValidator validations = new PortfolioValidator();
			ValidationResult result = validations.Validate(portfolio);
			if (result.IsValid)
			{
				portfolioManager.TUpdate(portfolio);
				return RedirectToAction("Index");
			}
			else
			{
				foreach(var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);


				}
			}return View();

		
		}
	}
}
