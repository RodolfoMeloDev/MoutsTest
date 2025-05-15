using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomer
{
    public class GetCustomerResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public CustomerStatus Status { get; set; }
    }
}
