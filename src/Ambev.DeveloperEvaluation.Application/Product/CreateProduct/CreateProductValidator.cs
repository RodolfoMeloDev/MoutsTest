using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Product.CreateProduct
{
    public class CreateProductValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductValidator()
        {
            RuleFor(product => product.Name).NotEmpty().Length(3, 50);
            RuleFor(product => product.Status).NotEqual(ProductStatus.Unknown);
        }
    }
}
