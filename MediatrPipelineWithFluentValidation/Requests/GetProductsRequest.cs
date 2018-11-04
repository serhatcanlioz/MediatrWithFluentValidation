using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatrPipelineWithFluentValidation.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatrPipelineWithFluentValidation.Requests
{
    public class GetProductsRequest:IRequest<GetProductsResponse>
    {
        [FromRoute(Name = "Id")]
        public int Id { get; set; }
    }
}
