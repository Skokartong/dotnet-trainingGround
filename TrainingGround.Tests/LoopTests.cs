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
}