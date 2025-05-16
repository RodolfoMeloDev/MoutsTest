using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Customer.CreateCustomer
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(user => user.Name).NotEmpty().Length(3, 50);
            RuleFor(user => user.Status).NotEqual(CustomerStatus.Unknown);
        }
    }
}
