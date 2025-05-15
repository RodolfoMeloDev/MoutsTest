namespace Ambev.DeveloperEvaluation.Application.Sale.CreateSale
{
    public class CreateSaleResult
    {
        public Guid Id { get; set; }

        public int OrderSale { get; }

        public DateTime DateOrderSale { get; set; }

        public decimal TotalSale { get; set;  }
    }
}
