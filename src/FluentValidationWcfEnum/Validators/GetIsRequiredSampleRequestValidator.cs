using FluentValidation;
using Ukpeewee.Examples.FluentValidationWcfEnum.Contracts.DataContracts;

namespace Ukpeewee.Examples.FluentValidationWcfEnum.Validators
{
    public class GetIsRequiredSampleRequestValidator : AbstractValidator<GetIsRequiredSampleRequest>
    {
        public GetIsRequiredSampleRequestValidator()
        {
            RuleFor(r => r.SampleEnumeration).NotNull().NotEmpty();
        }
    }
}