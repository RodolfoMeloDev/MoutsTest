using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.UpdateProduct
{
    public class UpdateProductResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public CustomerStatus Status { get; set; }
    }
}
