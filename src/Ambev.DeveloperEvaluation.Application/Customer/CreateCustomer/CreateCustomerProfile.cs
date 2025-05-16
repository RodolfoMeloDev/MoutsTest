using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
namespace Ambev.DeveloperEvaluation.Application.Customer.CreateCustomer
{
    public class CreateCustomerProfile : Profile
    {
        protected CreateCustomerProfile()
        {
            CreateMap<CreateCustomerCommand, Customers>();
            CreateMap<Customers, CreateCustomerResult>();
        }
    }
}
