using Xunit;

namespace TrainingGround.Tests;

public class ExceptionsTests
{
    // Method 1: Assert.Throws
    // More concise way to test for exceptions and more commonly used in xUnit tests
    [Fact]
    public void person_throws_exception_for_future_birth_year()
    {
        // Act 
        var exception = Assert.Throws<Exception>(() => new Person("Future Person", 3000, 1.75));

        // Assert
        Assert.Equal("Not born yet", exception.Message);
    }

    // Method 2: try-catch
    // More traditional way to test for exceptions
    [Fact]
    public void person_throws_exception_for_negative_birth_year()
    {
        try
        {
            // Arrange
            var person = new Person("Negative Year Person", -5000, 1.69);
            Assert.Fail("Exception was not thrown");
        }
        catch (System.Exception ex)
        {
            // Assert
            Assert.Equal("Person can't be born before year 0", ex.Message);
        }
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
