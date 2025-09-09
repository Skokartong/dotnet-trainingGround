using Xunit;

namespace TrainingGround.Tests;

public class ConditionalTests
{
    [Fact]
    public void set_age_group_sets_correct_age_group()
    {
        // Arrange
        var child = new Person("Anders", 2015, 1.2);
        var teen = new Person("Veronica", 2008, 1.5);
        var adult = new Person("Håkan", 1990, 2.1);
        var senior = new Person("Viktoria", 1950, 1.6);

        // Act
        child.SetAgeGroup();
        teen.SetAgeGroup();
        adult.SetAgeGroup();
        senior.SetAgeGroup();

        // Assert
        Assert.Equal(AgeGroup.Child, child.AgeGroup);
        Assert.Equal(AgeGroup.Teen, teen.AgeGroup);
        Assert.Equal(AgeGroup.Adult, adult.AgeGroup);
        Assert.Equal(AgeGroup.Senior, senior.AgeGroup);
    }

    [Fact]
    public void get_age_group_returns_correct_message()
    {
        // Arrange
        var child = new Person("Jörgen", 2015, 1.21);

        child.SetAgeGroup();
        var childMessage = "Just a child!";

        // Act
        var childResult = Person.GetAgeGroup(child.AgeGroup);

        // Assert
        Assert.Equal(childMessage, childResult);
    }
}