using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.CreateCustomer
{
    public class CreateCustomerRequest
    {
        public string Name { get; set; } = string.Empty;

        public CustomerStatus Status { get; set; }
    }
}
