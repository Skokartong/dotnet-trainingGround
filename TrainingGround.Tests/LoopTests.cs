using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace TrainingGround.Tests;

public class LoopTests
{
    [Fact]
    public void while_loop_counts_to_five()
    {
        // Arrange
        var count = 0;

        // Act
        while (count < 5)
        {
            Console.WriteLine("Count is: " + count);
            count++;
        }

        // Assert
        Assert.Equal(5, count);
    }

    [Fact]
    public void for_loop_iterates_over_array()
    {
        // Arrange
        var numbers = new int[] { 111, 222, 333, 444, 555 };

        // Act

        for (var i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Number at index " + i + " is: " + numbers[i]);
        }

        Assert.Equal(5, numbers.Length);
    }
}