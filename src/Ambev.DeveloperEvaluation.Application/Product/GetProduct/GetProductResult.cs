using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Product.GetProduct
{
    public class GetProductResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public CustomerStatus Status { get; set; }
    }
}
