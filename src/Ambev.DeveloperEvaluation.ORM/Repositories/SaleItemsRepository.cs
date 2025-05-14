using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    /// <summary>
    /// Implementation of ISaleItemRepository using Entity Framework Core
    /// </summary>
    public class SaleItemsRepository : ISaleItemRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of SaleItemsRepository
        /// </summary>
        /// <param name="context">The database context</param>
        public SaleItemsRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<bool> CanceledAsync(Guid saleId, int id, CancellationToken cancellationToken = default)
        {
            var saleDB = await GetByIdAsync(saleId, id, cancellationToken) ??
                throw new KeyNotFoundException("A chave de identificação do objeto não foi encontrada, não foi possível atualizar as informações.");

            saleDB.Cancelled = true;

            var result = await _context.SaveChangesAsync(cancellationToken);

            return result != 0;
        }

        /// <summary>
        /// Creates a new sale item in the database
        /// </summary>
        /// <param name="sale">The sale item to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created sale item</returns>
        public async Task<SaleItens> CreateAsync(SaleItens saleItens, CancellationToken cancellationToken = default)
        {
            await _context.SaleItens.AddAsync(saleItens, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return saleItens;
        }

        /// <summary>
        /// Retrieves a itens by their unique identifier and sale ID
        /// </summary>
        /// <param name="saleId">The unique identifier of the sale id</param>
        /// <param name="id">The unique identifier of the item</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The item if found, null otherwise</returns>
        public async Task<SaleItens?> GetByIdAsync(Guid saleId, int id, CancellationToken cancellationToken = default)
        {
            return await _context.SaleItens.FirstOrDefaultAsync(o => o.Id == id && o.SaleId.Equals(saleId), cancellationToken);
        }
    }
}
