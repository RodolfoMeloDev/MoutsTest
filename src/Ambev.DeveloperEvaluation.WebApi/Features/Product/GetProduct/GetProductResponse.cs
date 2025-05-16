using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.GetProduct
{
    public class GetProductResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ProductStatus Status { get; set; }
    }
}
