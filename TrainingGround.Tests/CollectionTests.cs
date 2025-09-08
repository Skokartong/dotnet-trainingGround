using Xunit;

namespace TrainingGround.Tests;

public class CollectionTests
{
    [Fact]
    public void an_array_has_a_length_property()
    {
        // Arrange
        var numbers = new int[] { 1, 2, 3, 4, 5 };

        // Act
        var length = numbers.Length;

        // Assert
        Assert.Equal(5, length);
    }
}