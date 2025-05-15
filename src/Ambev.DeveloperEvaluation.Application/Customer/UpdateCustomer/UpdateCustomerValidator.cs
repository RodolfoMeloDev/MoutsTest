using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Customer.UpdateCustomer
{
    public class UpdateCustomerValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("User ID is required");
            RuleFor(user => user.Name).NotEmpty().Length(3, 50).WithMessage("Name must have between 3 and 50 caracters");
            RuleFor(user => user.Status).NotEqual(CustomerStatus.Unknown).WithMessage("Status must not Unknow");
        }
    }
}
