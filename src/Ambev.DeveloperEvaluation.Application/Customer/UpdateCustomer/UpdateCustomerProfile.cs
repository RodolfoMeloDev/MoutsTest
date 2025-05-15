using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customer.UpdateCustomer
{
    public class UpdateCustomerProfile : Profile
    {
        public UpdateCustomerProfile()
        {
            CreateMap<Domain.Entities.Customer, UpdateCustomerResult>();
        }
    }
}
