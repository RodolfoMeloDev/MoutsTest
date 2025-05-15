using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer
{
    public class GetCustomerResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public CustomerStatus Status { get; set; }
    }
}
