using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Students.Common.Attributes;

public class CapitalLettersOnlyAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is string str && !string.IsNullOrEmpty(str))
        {
            if (char.IsLower(str[0]))
            {
                return new ValidationResult("Imię i nazwisko nie powinno zaczynać się z małej litery.");
            }
        }
        return ValidationResult.Success!;
    }
}
