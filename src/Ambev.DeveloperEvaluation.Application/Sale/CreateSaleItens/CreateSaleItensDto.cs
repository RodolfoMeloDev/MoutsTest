namespace Ambev.DeveloperEvaluation.Application.Sale.CreateSaleItens
{
    public class CreateSaleItensDto
    {
        public string ProductId { get; set; } = string.Empty;

        public int Quantities { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
