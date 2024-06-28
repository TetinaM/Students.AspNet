using FluentAssertions;
using Students.Common.Attributes;
using System.ComponentModel.DataAnnotations;
using Xunit;

public class CapitalLettersOnlyTests
{
    private readonly CapitalLettersOnlyAttribute _attribute = new CapitalLettersOnlyAttribute();

    [Theory]
    [InlineData("John", true)]
    [InlineData("john", false)]
    [InlineData("John Doe", true)]
    [InlineData("john Doe", false)]
    public void IsValid_ShouldValidateFirstLetterCapitalization(string input, bool expectedResult)
    {
        // Act
        var result = _attribute.GetValidationResult(input, new ValidationContext(new object()));

        // Assert
        if (expectedResult)
        {
            result.Should().Be(ValidationResult.Success);
        }
        else
        {
            result.Should().NotBe(ValidationResult.Success);
        }
    }
}