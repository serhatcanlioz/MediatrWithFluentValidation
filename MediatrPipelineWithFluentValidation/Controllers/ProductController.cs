using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatrPipelineWithFluentValidation.Requests;
using MediatrPipelineWithFluentValidation.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatrPipelineWithFluentValidation.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<GetProductsResponse>> GetProductsAsync(GetProductsRequest request)
        {
            var result = await _mediator.Send(request);
            if (result == null)
            {
                return NotFound("Product not found");
            }

            return Ok(result);
        }
    }
}