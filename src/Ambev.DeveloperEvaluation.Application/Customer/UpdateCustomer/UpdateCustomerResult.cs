using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Customer.UpdateCustomer
{
    public class UpdateCustomerResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ProductStatus Status { get; set; }
    }
}
