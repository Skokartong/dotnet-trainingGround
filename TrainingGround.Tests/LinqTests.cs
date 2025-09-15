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
    public void linq_to_return_all_positive_numbers_in_descending_order()
    {
        // Arrange 
        var numbers = new List<int> { 7, 101, 33, 20, -5, -3 };

        // Act
        var positiveNumbers = numbers
        .Where(n => n > 0)
        .OrderByDescending(n => n)
        .ToList();

        // Assert
        Assert.Equal(4, positiveNumbers.Count);
        Assert.All(positiveNumbers, n => Assert.True(n > 0));
    }

    [Fact]
    public void linq_to_find_first_number_larger_than_13()
    {
        // Arrange
        var numbers = new List<int> { 2, 20, 1, 9, 1, 17 };

        // Act
        var firstNumberLargerThan13 = numbers
        .Find(n => n > 13);

        // Assert
        Assert.Equal(20, firstNumberLargerThan13);
    }

    [Fact]
    public void linq_to_check_if_any_number_matches_criteria()
    {
        // Arrange
        var numbers = new List<int> { -2, 11, 1, 99, 1, 17 };

        // Act
        var anyNumberLargerThan100 = numbers
        .Any(n => n > 100);

        // Assert
        Assert.False(anyNumberLargerThan100);
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

    [Fact]
    public void linq_to_filter_ages_above_20_in_ascending_order()
    {
        // Arrange
        var people = new List<Person>
        {
            new Person("Annika", 2000, 1.6),
            new Person("Johanna", 1981, 1.8),
            new Person("Bengt", 2010, 1.5),
            new Person("Dave", 1975, 1.75),
            new Person("Eve", 2015, 1.4)
        };

        // Act
        var adults = people
        .Select(p => p.GetAge())
        .Where(age => age > 19)
        .OrderBy(age => age)
        .ToList();

        // Assert
        Assert.All(adults, age => Assert.True(age > 19));
        Assert.Equal(adults.OrderBy(a => a), adults);
        Assert.Equal(3, adults.Count);
    }
}

