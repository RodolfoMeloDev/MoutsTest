using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Name)
           .NotEmpty()
           .MinimumLength(3).WithMessage("Name must be at least 3 characters long.")
           .MaximumLength(100).WithMessage("Name cannot be longer than 100 characters.");
        }
    }
}
