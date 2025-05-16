using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.CreateProduct
{
    public class CreateProductRequest
    {
        public string Name { get; set; } = string.Empty;

        public ProductStatus Status { get; set; }
    }
}
