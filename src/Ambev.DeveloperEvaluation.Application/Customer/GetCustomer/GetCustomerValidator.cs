using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomer
{
    public class GetCustomerValidator : AbstractValidator<GetCustomerCommand>
    {
        public GetCustomerValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("User ID is required");
        }
    }
}
