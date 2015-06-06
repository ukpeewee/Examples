using FluentValidation;
using Ukpeewee.Examples.WcfService.Contracts.DataContracts;

namespace Ukpeewee.Examples.WcfService.Validators
{
    public class GetIsRequiredSampleRequestValidator : AbstractValidator<GetIsRequiredSampleRequest>
    {
        public GetIsRequiredSampleRequestValidator()
        {
            RuleFor(r => r.SampleEnumeration).NotNull().NotEmpty();
        }
    }
}