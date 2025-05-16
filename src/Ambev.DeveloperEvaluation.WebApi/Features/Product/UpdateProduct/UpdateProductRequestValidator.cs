using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.UpdateProduct
{
    public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
    {
        public UpdateProductRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("User ID is required");
            RuleFor(product => product.Name).NotEmpty().Length(3, 50);
            RuleFor(product => product.Status).NotEqual(ProductStatus.Unknown);
        }
    }
}
