using FluentValidation;
using Ukpeewee.Examples.FluentValidationWcfEnum.Contracts.DataContracts;

namespace Ukpeewee.Examples.FluentValidationWcfEnum.Validators
{
    public class GetGoodSampleRequestValidator : AbstractValidator<GetGoodSampleRequest>
    {
        public GetGoodSampleRequestValidator()
        {
            RuleFor(r => r.SampleEnumeration).NotNull().NotEmpty();
        }
    }
}