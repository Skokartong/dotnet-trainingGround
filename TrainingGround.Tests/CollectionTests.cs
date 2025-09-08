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

    [Fact]
    public void getting_items_from_array()
    {
        // Arrange
        var numbers = new int[] { 1, 2, 3 };
        var strings = new string[] { "one", "two", "three" };

        // Assert
        Assert.Equal(1, numbers[0]);
        Assert.Equal(3, numbers[2]);
        Assert.Equal("one", strings[0]);
        Assert.Equal("three", strings[2]);
    }

    [Fact]
    public void showing_object_initializer_syntax()
    {
        // Arrange
        var a = new Address("Gatan", 1, "Staden", 12345);
        var b = new Address("Gatan", 1, "Staden", 12345);

        // Assert
        Assert.Equal(b.Street, a.Street);
        Assert.Equal(b.StreetNumber, a.StreetNumber);
        Assert.Equal(b.City, a.City);
        Assert.Equal(b.ZipCode, a.ZipCode);
    }
}