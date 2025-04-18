﻿using Core_Portfolio.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Route("Writer/[controller]/[action]")]
	public class ProfileController : Controller
	{
		private readonly UserManager<WriterUser> _userManager;

		public ProfileController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public async Task<IActionResult>Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel model = new UserEditViewModel();
			model.Name = values.Name;
			model.Surname = values.Surname;
			model.PictureURL= values.ImageUrl;
			return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel p)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (p.Picture != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(p.Picture.FileName);
				var imageName = Guid.NewGuid() + extension;
				var saveLocation = resource + "/wwwroot/userImage/" + imageName;

				var stream = new FileStream(saveLocation, FileMode.Create);
				await p.Picture.CopyToAsync(stream);
				user.ImageUrl = imageName;
			}
			user.Name = p.Name;
			user.Surname = p.Surname;
			user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
			var result = await _userManager.UpdateAsync(user);
			if (result.Succeeded)
			{
				return Redirect("~/Login/Index");
			}
			return View();
		}
	}
}
