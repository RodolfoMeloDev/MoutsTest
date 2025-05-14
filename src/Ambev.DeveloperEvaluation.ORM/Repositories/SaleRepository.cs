using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    /// <summary>
    /// Implementation of ISaleRepository using Entity Framework Core
    /// </summary>
    public class SaleRepository : ISaleRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of SaleRepository
        /// </summary>
        /// <param name="context">The database context</param>
        public SaleRepository(DefaultContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Update a sale for cancelled in the database
        /// </summary>
        /// <param name="sale">The sale to cancelled</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The cancelled sale</returns>
        public async Task<bool> CanceledAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var saleDB = await GetByIdAsync(id, cancellationToken) ??
                throw new KeyNotFoundException("A chave de identificação do objeto não foi encontrada, não foi possível atualizar as informações.");

            saleDB.UpdatedAt = DateTime.UtcNow;
            saleDB.Status = SaleStatus.Cancelled;

            var result = await _context.SaveChangesAsync(cancellationToken);

            return result != 0;
        }

        /// <summary>
        /// Creates a new sale in the database
        /// </summary>
        /// <param name="sale">The sale to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created sale</returns>
        public async Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default)
        {
            await _context.Sales.AddAsync(sale, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return sale;
        }

        /// <summary>
        /// Retrieves a sale by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the sale</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The sale if found, null otherwise</returns>
        public async Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Sales.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
        }

        /// <summary>
        /// Update a sale in the database
        /// </summary>
        /// <param name="sale">The sale to update</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The updated sale</returns>
        public async Task<Sale> UpdateAsync(Sale sale, CancellationToken cancellationToken = default)
        {
            var saleDB = await GetByIdAsync(sale.Id, cancellationToken) ??
                throw new KeyNotFoundException("A chave de identificação do objeto não foi encontrada, não foi possível atualizar as informações.");

            sale.UpdatedAt = DateTime.UtcNow;

            _context.Entry(saleDB).CurrentValues.SetValues(sale);

            await _context.SaveChangesAsync(cancellationToken);

            return sale;
        }
    }
}
