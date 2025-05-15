using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Product.UpdateProduct
{
    public class UpdateProductProfile : Profile
    {
        public UpdateProductProfile()
        {
            CreateMap<Domain.Entities.Product, UpdateProductResult>();
        }
    }
}
