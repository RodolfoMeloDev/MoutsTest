using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customer.GetCustomer
{
    public class GetCustomerProfile : Profile
    {
        public GetCustomerProfile()
        {
            CreateMap<Domain.Entities.Customer, GetCustomerResult>();
        }
    }
}
