﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(2);
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Price).GreaterThan(0);
            RuleFor(p => p.Price).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
           // RuleFor(p => p.Name).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
                

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
