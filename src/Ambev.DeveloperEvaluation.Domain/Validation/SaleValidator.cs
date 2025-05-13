using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    public class SaleValidator : AbstractValidator<Sale>
    {
        public SaleValidator()
        {
            RuleFor(sale => sale.OrderSale)
           .GreaterThan(DateTime.Today)
           .WithMessage("Order Sale must be less than or equal to today");

            RuleFor(sale => sale.CustomerId)
           .NotEmpty()
           .NotNull()
           .WithMessage("CustomerId must be informated");

            RuleFor(sale => sale.Branch)
           .NotEmpty()
           .MinimumLength(3).WithMessage("Branch must be at least 3 characters long.")
           .MaximumLength(100).WithMessage("Branch cannot be longer than 100 characters.");

            RuleFor(sale => sale.TotalSale)
           .LessThanOrEqualTo(0)
           .WithMessage("Total sale must be greater zero");
        }
    }
}
