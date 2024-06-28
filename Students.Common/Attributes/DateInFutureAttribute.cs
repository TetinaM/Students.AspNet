using System;
using System.ComponentModel.DataAnnotations;

public class DateInFutureAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value is DateTime date && date < DateTime.Now)
        {
            return new ValidationResult("Data musi być w przyszłości.");
        }
        return ValidationResult.Success!;
    }
}

public class MinimumDurationAttribute : ValidationAttribute
{
    private readonly int _months;

    public MinimumDurationAttribute(int months)
    {
        _months = months;
    }

    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value is Tuple<DateTime, DateTime> dates)
        {
            var (startDate, endDate) = dates;
            if ((endDate - startDate).TotalDays < _months * 30)
            {
                return new ValidationResult($"Daty muszą być oddalone o co najmniej {_months} miesiące.");
            }
        }
        return ValidationResult.Success!;
    }
}