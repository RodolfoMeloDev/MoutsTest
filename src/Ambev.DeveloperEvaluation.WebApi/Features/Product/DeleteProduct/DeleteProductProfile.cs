using Ambev.DeveloperEvaluation.Application.Product.DeleteProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Product.DeleteProduct
{
    public class DeleteProductProfile : Profile
    {
        protected DeleteProductProfile()
        {
            CreateMap<Guid, DeleteProductCommand>()
                .ConstructUsing(id => new DeleteProductCommand(id));
        }
    }
}
