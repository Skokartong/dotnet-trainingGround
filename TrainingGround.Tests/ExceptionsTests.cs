using Xunit;

namespace TrainingGround.Tests;

public class ExceptionsTests
{
    [Fact]
    public void get_age_throws_exception_for_future_birth_year()
    {
        // Arrange
        var person = new Person("Future Person", 3000, 1.75);
        var currentYear = DateTime.Now.Year;

        // Act & Assert
        var exception = Assert.Throws<Exception>(() => person.GetAge(currentYear));
        Assert.Equal("Not born yet", exception.Message);
    }
}
