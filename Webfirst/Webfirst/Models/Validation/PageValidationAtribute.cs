using System.ComponentModel.DataAnnotations;

namespace Webfirst.Models.Validation;

    public class PageValidationAtribute : ValidationAttribute
    {
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is int numberOfPage)
        {
            if (numberOfPage < 0 || numberOfPage > 10000) 
            return new ValidationResult("Pages must be between 1 and 10000");
        }
        return ValidationResult.Success;
    }
}

