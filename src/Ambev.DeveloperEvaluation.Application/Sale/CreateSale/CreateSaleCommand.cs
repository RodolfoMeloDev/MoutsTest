using Ambev.DeveloperEvaluation.Application.Product.CreateProduct;
using Ambev.DeveloperEvaluation.Application.Sale.CreateSaleItens;
using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sale.CreateSale
{
    public class CreateSaleCommand : IRequest<CreateProductResult>
    {
        public DateTime DateOrderSale { get; set; }
        public string CustomerId { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public SaleStatus Status { get; set; }
        public IEnumerable<CreateSaleItensDto> Itens { get; set; } = [];
    }
}
