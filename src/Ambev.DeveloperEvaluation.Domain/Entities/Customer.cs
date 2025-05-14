using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Customer : BaseEntity, ICustomer
    {
        public Customer()
        {
            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets the customer's full name.
        /// Must not be null or empty.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets the customer's current status.
        /// Indicates whether the customer is active, inactive, or blocked in the system.
        /// </summary>
        public CustomerStatus Status { get; set; }

        /// <summary>
        /// Gets the date and time when the customer was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets the date and time of the last update to the customer's information.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        public Sale Sale { get; set; }

        /// <summary>
        /// Gets the unique identifier of the customer.
        /// </summary>
        /// <returns>The customer's ID as a string.</returns>
        string ICustomer.Id => Id.ToString();

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>The name.</returns>
        string ICustomer.Name => Name;

        /// <summary>
        /// Performs validation of the customer entity using the CustomerValidator rules.
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
            var validator = new CustomerValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }

        /// <summary>
        /// Activates the customer account.
        /// Changes the customer's status to Active.
        /// </summary>
        public void Activate()
        {
            Status = CustomerStatus.Active;
            UpdatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Deactivates the customer account.
        /// Changes the customer's status to Inactive.
        /// </summary>
        public void Deactivate()
        {
            Status = CustomerStatus.Inactive;
            UpdatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Blocks the customer account.
        /// Changes the customer's status to Blocked.
        /// </summary>
        public void Suspend()
        {
            Status = CustomerStatus.Suspended;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
