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

    [Fact]
    public void foreach_loop_iterates_over_list()
    {
        // Arrange
        var alphabet = new List<char> { 'A', 'B', 'C', 'D', 'E' };

        foreach (var letter in alphabet)
        {
            Console.WriteLine("Letter: " + letter);
        }

        // Assert
        Assert.Equal(5, alphabet.Count);
    }

    [Fact]
    public void foreach_loop_iterates_over_students()
    {
        // Arrange
        var students = new List<Student>();

        students.Add(new Student("Alice", 2000, 1.65, "S1"));
        students.Add(new Student("Bob", 1999, 1.75, "S2"));
        students.Add(new Student("Charlie", 2001, 1.80, "S3"));

        // Act
        foreach (var student in students)
        {
            Console.WriteLine("Student: " + student.Name + ", Birth Year: " + student.BirthYear);
        }

        // Assert
        Assert.Equal(3, students.Count);
    }
}