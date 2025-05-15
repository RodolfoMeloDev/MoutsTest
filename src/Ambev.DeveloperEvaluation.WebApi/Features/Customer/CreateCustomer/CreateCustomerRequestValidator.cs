using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.CreateCustomer
{
    public class CreateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerRequestValidator()
        {
            RuleFor(customer => customer.Name).NotEmpty().Length(3, 50);
            RuleFor(customer => customer.Status).NotEqual(CustomerStatus.Unknown);
        }
    }
}
