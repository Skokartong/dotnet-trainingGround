using FluentAssertions;
using Xunit;

namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    [Fact]
    public void someone_born_in_1975_is_50_in_2025()
    {
        // Arrange
        var age = AgeCalculator.CalculateAge(2025, 1975);

        // Assert
        age.Should().Be(50);
    }

    [Fact]
    public void someone_born_in_future_years_throws_exception()
    {
        // Arrange & Act
        Action act = () => AgeCalculator.CalculateAge(2025, 3000);

        // Assert
        act.Should().Throw<Exception>().WithMessage("Not born yet");
    }

    [Fact]
    public void someone_born_in_a_negative_year_throws_exception()
    {
        // Arrange & Act
        Action act = () => AgeCalculator.CalculateAge(2025, -5000);

        // Assert
        act.Should().Throw<Exception>().WithMessage("Person can't be born before year 0");
    }
}