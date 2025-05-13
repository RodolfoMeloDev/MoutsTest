namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação dos itens do pedido.
    /// </summary>
    public interface ISaleItens
    {
        /// <summary>
        /// Obtém o identificador do item do pedido.
        /// </summary>
        /// <returns>O ID do item do pedido como um inteiro.</returns>
        public int Id { get; }
        
        /// <summary>
        /// Obtém o identificador do pedido.
        /// </summary>
        /// <returns>O ID do pedido como um strings.</returns>
        public string SaleId { get; }

        /// <summary>
        /// Obtém o identificador do produto.
        /// </summary>
        /// <returns>O ID do produto como um string.</returns>
        public string ProductId { get; }

        /// <summary>
        /// Obtém a quantidade de compra do produto.
        /// </summary>
        /// <returns>A quantidade do produto como um inteiro.</returns>
        public int Quantities { get; }

        /// <summary>
        /// Obtém o preço unitário do produto.
        /// </summary>
        /// <returns>O preço unitário do produto como um decimal.</returns>
        public decimal UnitPrice { get; }

        /// <summary>
        /// Obtém o desconto do produto.
        /// </summary>
        /// <returns>O desconto do produto como um decimal.</returns>
        public decimal Discount { get; }

        /// <summary>
        /// Obtém o preço total produto no pedido.
        /// </summary>
        /// <returns>O preço total do produto como um decimal.</returns>
        public decimal TotalPrice { get; }

        /// <summary>
        /// Obtém se o item foi cancelado no pedido.
        /// </summary>
        /// <returns>O identificaro se o produto foi cancelado como um boolean.</returns>
        public bool Cancelled { get; }
    }
}
