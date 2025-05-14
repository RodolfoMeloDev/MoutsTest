using System.ComponentModel.DataAnnotations.Schema;
using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class SaleItens : ISaleItens
    {
        /// <summary>
        /// Gets the unique identifier 
        /// </summary>
        /// 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Gets the unique identifier by sale
        /// Must not be null or empty.
        /// </summary>
        public Guid SaleId { get; set; } = Guid.Empty;
        public Sale? Sale { get; set; }

        /// <summary>
        /// Gets the unique identifier by product
        /// Must not be null or empty.
        /// </summary>
        public string ProductId { get; set; } = string.Empty;
        public Product? Product { get; set; }

        /// <summary>
        /// Gets the amount itens
        /// </summary>
        public int Quantities { get; set; }

        /// <summary>
        /// Gets the unit price
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets the discount
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets the amount total price
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Gets the item canceled
        /// </summary>
        public bool Cancelled { get; set; } = false;

        /// <summary>
        /// Performs validation of the sale entity using the SaleItemValidator rules.
        /// </summary>
        /// <returns>
        /// A <see cref="ValidationResultDetail"/> containing:
        /// - IsValid: Indicates whether all validation rules passed
        /// - Errors: Collection of validation errors if any rules failed
        /// </returns>
        /// <remarks>
        /// <listheader>The validation includes checking:</listheader>
        /// <list type="bullet">SaleId null or empty</list>
        /// <list type="bullet">ProductId null or empty</list>
        /// <list type="bullet">Quantities must be greter zero</list>
        /// <list type="bullet">UnitPrice must be greter zero</list>
        /// <list type="bullet">Discount must be maximum 20%</list>
        /// <list type="bullet">TotalPrice must be greter zero</list>
        /// 
        /// </remarks>
        public ValidationResultDetail Validate()
        {
            var validator = new SaleItemValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }

        /// <summary>
        /// Canceled the sale
        /// </summary>
        public void CancelledItem()
        {
            Cancelled = true;
        }
    }
}
