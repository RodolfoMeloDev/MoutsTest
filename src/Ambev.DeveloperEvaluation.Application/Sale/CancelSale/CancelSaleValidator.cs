﻿using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sale.CancelSale
{
    public class CancelSaleValidator : AbstractValidator<CancelSaleCommand>
    {
        public CancelSaleValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("User ID is required");
        }
    }
}
