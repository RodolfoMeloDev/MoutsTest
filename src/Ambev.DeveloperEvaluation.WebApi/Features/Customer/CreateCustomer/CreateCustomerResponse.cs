using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.CreateCustomer
{
    public class CreateCustomerResponse
    {
        /// <summary>
        /// Obtém o identificador único do cliente
        /// </summary>
        /// <returns>O ID do cliente como um string.</returns>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Obtém o nome do cliente
        /// </summary>
        /// <returns>O Nome do cliente.</returns>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets the customer's current status.
        /// Indicates whether the customer is active, inactive, or blocked in the system.
        /// </summary>
        public CustomerStatus Status { get; set; }
    }
}
