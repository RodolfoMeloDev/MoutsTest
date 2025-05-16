using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomer
{
    public class GetCustomerProfile : Profile
    {
        public GetCustomerProfile()
        {
            CreateMap<Customers, GetCustomerResult>();
        }
    }
}
