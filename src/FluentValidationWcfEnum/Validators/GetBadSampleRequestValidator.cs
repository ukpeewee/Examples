using FluentValidation;
using Ukpeewee.Examples.WcfService.Contracts.DataContracts;

namespace Ukpeewee.Examples.WcfService.Validators
{
    public class GetBadSampleRequestValidator : AbstractValidator<GetBadSampleRequest>
    {
        public GetBadSampleRequestValidator()
        {
            RuleFor(r => r.SampleEnumeration).NotNull().NotEmpty();
        }
    }
}