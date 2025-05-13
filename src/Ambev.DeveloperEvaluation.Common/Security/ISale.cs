using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação do pedido.
    /// </summary>
    public interface ISale
    {
        /// <summary>
        /// Obtém o identificador do pedido.
        /// </summary>
        /// <returns>O ID do pedido como um string.</returns>
        public string Id { get; }

        /// <summary>
        /// Obtém a data/hora do pedido.
        /// </summary>
        /// <returns>A Data/Hora do pedido como um DateTime.</returns>
        public DateTime OrderSale { get; }

        /// <summary>
        /// Obtém do cliente do pedido.
        /// </summary>
        /// <returns>O ID do cliente do pedido como um string.</returns>
        public string CustomerId { get; }

        /// <summary>
        /// Obtém o preço total do pedido.
        /// </summary>
        /// <returns>O preço total do pedido como um decimal.</returns>
        public decimal TotalSale { get; }

        /// <summary>
        /// Obtém o nome da filial que realizou o pedido.
        /// </summary>
        /// <returns>O Nome da filial que realizou o pedido como um string.</returns>
        public string Branch { get; }

    }
}
