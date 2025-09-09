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
        var a = new Address();
        a.Street = "Gatan";
        a.StreetNumber = 1;
        a.City = "Staden";
        a.ZipCode = 12345;

        var b = new Address
        {
            Street = "Gatan",
            StreetNumber = 1,
            City = "Staden",
            ZipCode = 12345
        };

        // Assert
        Assert.Equal(b.Street, a.Street);
        Assert.Equal(b.StreetNumber, a.StreetNumber);
        Assert.Equal(b.City, a.City);
        Assert.Equal(b.ZipCode, a.ZipCode);
    }

    [Fact]
    public void a_list_is_very_flexible()
    {
        // Arrange
        var integerList = new List<int>();

        // Act
        integerList.Add(1);
        integerList.Add(2);
        integerList.Add(3);

        integerList.RemoveAt(0); // Removes the first item at index 0

        // Assert
        Assert.Equal(2, integerList[0]);
        Assert.Equal(3, integerList[1]);
        Assert.Equal(2, integerList.Count);
    }

    [Fact]
    public void a_list_can_hold_any_type()
    {
        // Arrange
        var objectList = new List<object>();
        var person = new Person("Lennart", 1980, 1.75, new Address("Street", 100, "New York", 111111));
        objectList.Add(person);
        objectList.Add("A string");
        objectList.Add(100);

        // Assert
        Assert.Equal(3, objectList.Count);
        Assert.IsType<Person>(objectList[0]);
        Assert.IsType<string>(objectList[1]);
        Assert.IsType<int>(objectList[2]);
    }
}