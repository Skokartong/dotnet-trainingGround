using Xunit;

namespace TrainingGround.Tests;

public class LinqTests
{
    [Fact]
    public void linq_to_check_if_all_numbers_are_positive()
    {
        // Arrange
        var numbers = new List<int> { 3, 4, 8, 9, 13, -2, -4 };

        // Act
        var allPositive = numbers
        .All(n => n > 0);

        // Assert
        Assert.False(allPositive);
    }

    [Fact]
    public void linq_to_find_first_letter_at_correct_index()
    {
        // Arrange
        var letters = new List<char> { 'a', 'b', 'b', 'c', 'b', 'q', 'z' };

        // Act
        var firstIndexB = letters
        .FindIndex(l => l == 'b');

        // Assert
        Assert.Equal(1, firstIndexB);
    }

    [Fact]
    public void linq_to_find_names_longer_than_four_letters()
    {
        // Arrange
        var names = new List<Person>
        {
            new Person("Anna", 2005, 1.6),
            new Person("Bertil", 1980, 1.8),
            new Person("Cecilia", 2010, 1.5),
            new Person("David", 1975, 1.75),
            new Person("Eva", 2015, 1.4)
        };

        // Act
        var longNames = names
        .Where(n => n.Name?.Length > 4)
        .ToList();

        // Assert
        Assert.Equal(3, longNames.Count);
    }
}

