using EntityLayer.Concreate;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim alanı boş geçilemez.");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Resim alanı boş geçilemez.");

        } 
    }
}
