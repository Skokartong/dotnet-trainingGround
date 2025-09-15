using Xunit;

namespace TrainingGround.Tests;

public class ExceptionsTests
{
    // Method 1: Assert.Throws
    // More concise way to test for exceptions and more commonly used in xUnit tests
    [Fact]
    public void get_age_throws_exception_for_future_birth_year()
    {
        // Arrange
        var person = new Person("Future Person", 3000, 1.75);
        var currentYear = DateTime.Now.Year;

        // Act & Assert
        var exception = Assert.Throws<Exception>(() => person.GetAge());
        Assert.Equal("Not born yet", exception.Message);
    }

    // Method 2: try-catch
    // More traditional way to test for exceptions
    [Fact]
    public void get_age_throws_exception_for_negative_birth_year()
    {
        try
        {
            // Arrange
            var person = new Person("Negative Year Person", -5000, 1.69);
            var currentYear = DateTime.Now.Year;

            // Act
            var age = person.GetAge();
        }
        catch (System.Exception ex)
        {
            // Assert
            Assert.Equal("Person can't be born before year 0", ex.Message);
            return;
        }

        Assert.Fail("Exception was not thrown");
    }

    [Fact]
    public void divide_by_zero_throws_exception()
    {
        try
        {
            // Arrange
            var i = 1;

            // Act
            var result = 1 / (i - 1);
        }
        catch (System.DivideByZeroException ex)
        {
            // Assert
            Assert.IsType<System.DivideByZeroException>(ex);
        }
    }
}
