using System.ComponentModel.DataAnnotations;

namespace Webfirst.Models.Validation;

public class YearValidationAtribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is int year)
        {
            int currentYear = DateTime.Now.Year;
            if (year >= currentYear)
                return new ValidationResult($"The year must be less than or equal to {currentYear}");
        }
        return ValidationResult.Success;
    }
}

