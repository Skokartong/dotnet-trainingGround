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
        var allPositive = numbers.All(n => n > 0);

        // Assert
        Assert.False(allPositive);
    }

    [Fact]
    public void linq_to_find_first_letter_at_correct_index()
    {
        // Arrange
        var letters = new List<char> { 'a', 'b', 'b', 'c', 'b', 'q', 'z' };

        // Act
        var firstIndexB = letters.FindIndex(l => l == 'b');

        // Assert
        Assert.Equal(1, firstIndexB);
    }
}

