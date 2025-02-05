using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class PortfolioValidator:AbstractValidator<Portfolio>
	{
		public PortfolioValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez.");
			RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Proje URL alanı boş geçilemez.");
			RuleFor(x => x.image1).NotEmpty().WithMessage("Image1 alanı boş geçilemez.");
			RuleFor(x => x.Platform).NotEmpty().WithMessage("Plaform alanı boş geçilemez.");
			RuleFor(x => x.Status).NotEmpty().WithMessage("Durum alanı boş geçilemez.");
			RuleFor(x => x.Name).MinimumLength(5).WithMessage("Projenin adı en az 5 karakterden oluşmak zorundadır.");
		}
	}
}
