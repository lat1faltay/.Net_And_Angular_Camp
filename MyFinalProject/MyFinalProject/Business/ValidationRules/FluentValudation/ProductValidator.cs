using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValudation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);

            // Kendi yazdığımız kuralı kullandık
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
        }

        // Burada kendi kuralımızı yazdık
        // Kuralın kullanıldığı yerlerde ürünlerin adı sadece A karakteri ile başlayabilir. Bunu string fonksiyonlarından olan arg StartWith ile yaptık
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
