using System;
using System.Linq;
using FluentValidation.Results;
using Ukpeewee.Examples.FluentValidationWcfEnum.Contracts;
using Ukpeewee.Examples.FluentValidationWcfEnum.Contracts.DataContracts;
using Ukpeewee.Examples.FluentValidationWcfEnum.Validators;

namespace Ukpeewee.Examples.FluentValidationWcfEnum.Service
{
    public class SampleService : ISampleService
    {
        public GetSampleResponse GetBadSample(GetBadSampleRequest request)
        {
            var getBadSampleRequestValidator = new GetBadSampleRequestValidator();
            ValidationResult validationResult = getBadSampleRequestValidator.Validate(request);

            return new GetSampleResponse
            {
                IsValid = validationResult.IsValid,
                ValidationFailures = validationResult.Errors.Aggregate(string.Empty, (current, failure) => current + failure.ErrorMessage + Environment.NewLine)
            };
        }

        public GetSampleResponse GetGoodSample(GetGoodSampleRequest request)
        {
            var getGoodSampleRequestValidator = new GetGoodSampleRequestValidator();
            ValidationResult validationResult = getGoodSampleRequestValidator.Validate(request);

            return new GetSampleResponse
            {
                IsValid = validationResult.IsValid,
                ValidationFailures = validationResult.Errors.Aggregate(string.Empty, (current, failure) => current + failure.ErrorMessage + Environment.NewLine)
            };
        }

        public GetSampleResponse GetIsRequiredSample(GetIsRequiredSampleRequest request)
        {
            var getGoodSampleRequestValidator = new GetIsRequiredSampleRequestValidator();
            ValidationResult validationResult = getGoodSampleRequestValidator.Validate(request);

            return new GetSampleResponse
            {
                IsValid = validationResult.IsValid,
                ValidationFailures = validationResult.Errors.Aggregate(string.Empty, (current, failure) => current + failure.ErrorMessage + Environment.NewLine)
            };
        }
    }
}