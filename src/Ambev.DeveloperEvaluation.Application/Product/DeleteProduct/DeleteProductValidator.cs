using Ambev.DeveloperEvaluation.Application.Customer.DeleteCustomer;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Product.DeleteProduct
{
    public class DeleteProductValidator : AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteProductValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("User ID is required");
        }
    }
}
