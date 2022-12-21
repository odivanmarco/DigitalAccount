﻿using FluentValidation.Results;

namespace WebApi.Models.Error
{
    public static class ValidationFailureExtension 
    {
        public static IList<CustomValidationFailure> ToCustomValidationFailures(this IList<ValidationFailure> failures)
        {
            return failures.Select(f => new CustomValidationFailure(f.PropertyName, f.ErrorMessage)).ToList();
        }
    }
}
