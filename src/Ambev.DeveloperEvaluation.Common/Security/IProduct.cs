namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de um produto no sistema.
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Obtém o identificador único do produto.
        /// </summary>
        /// <returns>O ID do produto como um inteiro.</returns>
        public string Id { get; }

        /// <summary>
        /// Obtém o nome do produto.
        /// </summary>
        /// <returns>O nome do produto.</returns>
        public string Name { get; }
    }
}
