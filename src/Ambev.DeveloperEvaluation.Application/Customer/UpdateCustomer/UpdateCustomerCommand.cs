using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.UpdateCustomer
{
    public class UpdateCustomerCommand : IRequest<UpdateCustomerResult>
    {
        public Guid Id { get; }

        public string Name { get; set; } = string.Empty;

        public CustomerStatus Status { get; set; }
    }
}
