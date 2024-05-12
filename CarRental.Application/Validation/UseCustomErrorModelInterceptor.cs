using System.Text.Json;
using CarRental.Data.Models;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Application.Validation
{
    public class UseCustomErrorModelInterceptor : IValidatorInterceptor
    {
        public IValidationContext BeforeAspNetValidation(ActionContext actionContext, IValidationContext commonContext)
        {
            return commonContext;
        }

        public ValidationResult AfterAspNetValidation(ActionContext actionContext, IValidationContext validationContext,
            ValidationResult result)
        {
            var failures = result.Errors.Select(error => new ValidationFailure(error.PropertyName, SerializeError(error)));
            return new ValidationResult(failures);
        }

        private static string SerializeError(ValidationFailure failure)
        {
            var error = new Error(failure.PropertyName, failure.ErrorMessage);
            return JsonSerializer.Serialize(error);
        }
    }
}
