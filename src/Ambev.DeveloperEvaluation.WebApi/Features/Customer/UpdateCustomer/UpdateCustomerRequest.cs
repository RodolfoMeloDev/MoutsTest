using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.UpdateCustomer
{
    public class UpdateCustomerRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public CustomerStatus Status { get; set; }
    }
}
