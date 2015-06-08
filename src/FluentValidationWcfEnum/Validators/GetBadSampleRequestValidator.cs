using FluentValidation;
using Ukpeewee.Examples.FluentValidationWcfEnum.Contracts.DataContracts;

namespace Ukpeewee.Examples.FluentValidationWcfEnum.Validators
{
    public class GetBadSampleRequestValidator : AbstractValidator<GetBadSampleRequest>
    {
        public GetBadSampleRequestValidator()
        {
            RuleFor(r => r.SampleEnumeration).NotNull().NotEmpty();
        }
    }
}