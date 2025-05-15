using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.UpdateCustomer
{
    public class UpdateCustomerRequestValidator : AbstractValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("User ID is required");
            RuleFor(customer => customer.Name).NotEmpty().Length(3, 50);
            RuleFor(customer => customer.Status).NotEqual(CustomerStatus.Unknown);
        }

    }
}
