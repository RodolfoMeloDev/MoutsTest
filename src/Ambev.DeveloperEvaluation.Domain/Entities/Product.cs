using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Product : BaseEntity, IProduct
    {
        public Product()
        {
            CreatedAt = DateTime.Now;
        }

        /// <summary>
        /// Gets the product's full name.
        /// Must not be null or empty.
        /// </summary>
        public string Name {  get; set; } = string.Empty;

        /// <summary>
        /// Gets the product's current status.
        /// Indicates whether the product is active, inactive, or blocked in the system.
        /// </summary>
        public ProductStatus Status { get; set; }

        /// <summary>
        /// Gets the date and time when the product was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets the date and time of the last update to the product's information.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }    
        
        public SaleItens? SaleItens { get; set; }

        /// <summary>
        /// Gets the unique identifier of the product.
        /// </summary>
        /// <returns>The product's ID as a string.</returns>
        string IProduct.Id => Id.ToString();

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>The name.</returns>
        string IProduct.Name => Name;

        /// <summary>
        /// Performs validation of the product entity using the ProductValidator rules.
        /// </summary>
        /// <returns>
        /// A <see cref="ValidationResultDetail"/> containing:
        /// - IsValid: Indicates whether all validation rules passed
        /// - Errors: Collection of validation errors if any rules failed
        /// </returns>
        /// <remarks>
        /// <listheader>The validation includes checking:</listheader>
        /// <list type="bullet">Name format and length</list>
        /// 
        /// </remarks>
        public ValidationResultDetail Validate()
        {
            var validator = new ProductValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }

        /// <summary>
        /// Activates the product account.
        /// Changes the product's status to Active.
        /// </summary>
        public void Activate()
        {
            Status = ProductStatus.Active;
            UpdatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Deactivates the product account.
        /// Changes the product's status to Inactive.
        /// </summary>
        public void Deactivate()
        {
            Status = ProductStatus.Inactive;
            UpdatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Blocks the product account.
        /// Changes the product's status to Blocked.
        /// </summary>
        public void Suspend()
        {
            Status = ProductStatus.Suspended;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
