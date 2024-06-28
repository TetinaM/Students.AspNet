using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class PolishPostalCodeAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value is string str && !string.IsNullOrEmpty(str))
        {
            var regex = new Regex(@"^\d{2}-\d{3}$");
            if (!regex.IsMatch(str))
            {
                return new ValidationResult("Kod pocztowy powinien być zgodny z polskim formatem (XX-XXX).");
            }
        }
        return ValidationResult.Success!;
    }
}