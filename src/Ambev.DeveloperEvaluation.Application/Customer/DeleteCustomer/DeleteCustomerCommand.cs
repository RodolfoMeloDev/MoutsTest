using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customer.DeleteCustomer
{
    public class DeleteCustomerCommand : IRequest<DeleteCustomerResponse>
    {
        public Guid Id { get; }

        public DeleteCustomerCommand(Guid id)
        {
            Id = id;
        }
    }
}
