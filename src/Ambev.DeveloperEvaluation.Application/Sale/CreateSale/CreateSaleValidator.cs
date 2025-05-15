using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sale.CreateSale
{
    public class CreateSaleValidator : AbstractValidator<CreateSaleCommand>
    {
        public CreateSaleValidator()
        {
            RuleFor(sale => sale.DateOrderSale).LessThanOrEqualTo(DateTime.UtcNow);
            RuleFor(sale => sale.Branch).NotEmpty();
            RuleFor(sale => sale.CustomerId).NotEmpty();
            RuleFor(sale => sale.Status).NotEqual(SaleStatus.Cancelled);
            RuleFor(sale => sale.Itens).Must(i => !i.Any());
        }
    }
}
