﻿using Ambev.DeveloperEvaluation.Application.Customer.GetCustomer;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.GetCustomer
{
    public class GetCustomerProfile : Profile
    {
        public GetCustomerProfile()
        {
            CreateMap<Guid, GetCustomerCommand>()
                .ConstructUsing(id => new GetCustomerCommand(id));
        }
    }
}
