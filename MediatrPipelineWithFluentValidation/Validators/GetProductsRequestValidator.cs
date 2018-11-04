using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using MediatrPipelineWithFluentValidation.Requests;

namespace MediatrPipelineWithFluentValidation.Validators
{
    public class GetProductsRequestValidator : AbstractValidator<GetProductsRequest>
    {
        public GetProductsRequestValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("ID 0' dan büyük olmalı.");
        }
    }
}
