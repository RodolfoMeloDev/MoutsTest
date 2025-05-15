using Ambev.DeveloperEvaluation.Application.Customer.DeleteCustomer;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.DeleteProduct
{
    public class DeleteProductCommand : IRequest<DeleteCustomerResponse>
    {
        public Guid Id { get; }

        public DeleteProductCommand(Guid id)
        {
            Id = id;
        }
    }
}
