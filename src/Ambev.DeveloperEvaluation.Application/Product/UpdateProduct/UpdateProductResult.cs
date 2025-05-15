using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Product.UpdateProduct
{
    public class UpdateProductResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ProductStatus Status { get; set; }
    }
}
