using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatrPipelineWithFluentValidation.Requests;
using MediatrPipelineWithFluentValidation.Responses;
using MediatR;

namespace MediatrPipelineWithFluentValidation.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsRequest, GetProductsResponse>
    {
        public Task<GetProductsResponse> Handle(GetProductsRequest request, CancellationToken cancellationToken)
        {
            var products = new List<GetProductsResponse>
            {
                new GetProductsResponse{Id = 1,ProductName = "Product1"},
                new GetProductsResponse{Id = 2,ProductName = "Product2"},
                new GetProductsResponse{Id = 3,ProductName = "Product3"}
            };
            return Task.FromResult(products.FirstOrDefault(x => x.Id == request.Id));
        }
    }
}
