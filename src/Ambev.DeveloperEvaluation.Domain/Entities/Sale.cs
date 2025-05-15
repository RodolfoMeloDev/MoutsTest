using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale : BaseEntity, ISale
    {
        public Sale()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public int OrderSale { get; set; }

        /// <summary>
        /// Gets the datetime do sale
        /// Must be null date today.
        /// </summary>
        public DateTime DateOrderSale {  get; set; }

        /// <summary>
        /// Gets the customer's ID
        /// Must not be null or empty.
        /// </summary>
        public string CustomerId { get; set; } = string.Empty;

        public Customer? Customer { get; set; }

        public ICollection<SaleItens>? Itens { get; set; }

        /// <summary>
        /// Gets the total sale
        /// Must not be zero or negative.
        /// </summary>
        public decimal TotalSale { get; }

        /// <summary>
        /// Gets the branch
        /// Must not be null or empty.
        /// </summary>
        public string Branch { get; set; } = string.Empty;

        /// <summary>
        /// Gets the sale's current status.
        /// Indicates whether the sale is active or cancelled in the system.
        /// </summary>
        public SaleStatus Status { get; set; } = SaleStatus.Active;

        /// <summary>
        /// Gets the date and time when the sale was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets the date and time of the last update to the sale's information.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets the unique identifier of the sale.
        /// </summary>
        /// <returns>The sale's ID as a string.</returns>
        string ISale.Id => Id.ToString();

        /// <summary>
        /// Performs validation of the sale entity using the SaleValidator rules.
        /// </summary>
        /// <returns>
        /// A <see cref="ValidationResultDetail"/> containing:
        /// - IsValid: Indicates whether all validation rules passed
        /// - Errors: Collection of validation errors if any rules failed
        /// </returns>
        /// <remarks>
        /// <listheader>The validation includes checking:</listheader>
        /// <list type="bullet">Order Sale validate date</list>
        /// <list type="bullet">CustomerId null or empty</list>
        /// <list type="bullet">Branch null or empty</list>
        /// <list type="bullet">TotalSale must be greter zero</list>
        /// 
        /// </remarks>
        public ValidationResultDetail Validate()
        {
            var validator = new SaleValidator();
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
        public void Cancelled()
        {
            Status = SaleStatus.Cancelled;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
