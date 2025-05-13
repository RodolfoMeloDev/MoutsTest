using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ISaleItemRepository
    {
        /// <summary>
        /// Creates a new SaleItens in the repository
        /// </summary>
        /// <param name="saleItens">The saleItens to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created sale</returns>
        Task<SaleItens> CreateAsync(SaleItens saleItens, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a saleItens by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the saleItens</param>
        /// <param name="saleId">The unique identifier of the sale</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The saleItens if found, null otherwise</returns>
        Task<SaleItens?> GetByIdAsync(Guid saleId, int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Canceled a sale from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the saleItens</param>
        /// <param name="saleId">The unique identifier of the sale</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the sale was canceled, false if not found</returns>
        Task<bool> CanceledAsync(Guid saleId, int id, CancellationToken cancellationToken = default);
    }
}
