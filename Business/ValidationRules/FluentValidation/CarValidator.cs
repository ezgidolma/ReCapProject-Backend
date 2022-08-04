using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()//Kurallar bunun içine yazılır
        {
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).MinimumLength(1);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(100).When(p => p.Id == 1);//Ücret 100 ve üstü olmalı
            RuleFor(p => p.Description).Must(StartWithA).WithMessage("Ürünler A harfiyle başlamalı.");//kendi yazacağımız metot

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");//A ile başlıyorsa true 
        }
    }
}
