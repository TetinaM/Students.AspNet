using System.ComponentModel.DataAnnotations;
using System.Linq;

public class SubjectNameAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value is string str && !string.IsNullOrEmpty(str))
        {
            if (char.IsLower(str[0]) || str.Any(char.IsDigit))
            {
                return new ValidationResult("Nazwa przedmiotu nie może zawierać cyfr oraz nie może zaczynać się z małej litery.");
            }
        }
        return ValidationResult.Success!;
    }
}