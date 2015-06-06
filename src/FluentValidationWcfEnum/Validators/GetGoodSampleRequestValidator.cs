using FluentValidation;
using Ukpeewee.Examples.WcfService.Contracts.DataContracts;

namespace Ukpeewee.Examples.WcfService.Validators
{
    public class GetGoodSampleRequestValidator : AbstractValidator<GetGoodSampleRequest>
    {
        public GetGoodSampleRequestValidator()
        {
            RuleFor(r => r.SampleEnumeration).NotNull().NotEmpty();
        }
    }
}