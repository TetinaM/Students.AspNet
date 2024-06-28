using FluentAssertions;
using Students.Common.Attributes;
using System.ComponentModel.DataAnnotations;
using Xunit;

public class PolishPostalCodeAttributeTests
{
    private readonly PolishPostalCodeAttribute _attribute = new PolishPostalCodeAttribute();

    [Theory]
    [InlineData("00-000", true)]
    [InlineData("00000", false)]
    [InlineData("00-00", false)]
    [InlineData("000-000", false)]
    public void IsValid_ShouldValidatePostalCode(string input, bool expectedResult)
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