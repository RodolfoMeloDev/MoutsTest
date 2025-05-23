﻿using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Product.GetProduct
{
    public class GetProductCommand : IRequest<GetProductResult>
    {
        public Guid Id { get; }

        public GetProductCommand(Guid id)
        {
            Id = id;
        }
    }
}
