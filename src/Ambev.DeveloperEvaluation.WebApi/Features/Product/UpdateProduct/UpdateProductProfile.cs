using Ambev.DeveloperEvaluation.Application.Product.CreateProduct;
using Ambev.DeveloperEvaluation.WebApi.Features.Product.CreateProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.UpdateProduct
{
    public class UpdateProductProfile : Profile
    {
        protected UpdateProductProfile()
        {
            CreateMap<UpdateProductRequest, CreateProductCommand>();
            CreateMap<Domain.Entities.Product, CreateProductResponse>();
        }
    }
}
