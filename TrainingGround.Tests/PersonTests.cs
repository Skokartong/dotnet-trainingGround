using Xunit;

namespace TrainingGround.Tests;

public class PersonTests
{
    [Fact]
    public void create_person_with_constructor()
    {
        // Act
        var person = new Person("Hilda", 1972, 1.7);

        // Assert
        Assert.NotNull(person);
    }

    [Fact]
    public void age_returns_correct_birthyear()
    {
        // Act
        var person = new Person("Hilda", 50, 1.7, true);

        // Assert
        Assert.Equal(person.BirthYear, DateTime.Now.Year - 50);
    }

    [Fact]
    public void a_person_has_an_adress()
    {
        // Arrange
        var person = new Person("Hilda", 50, 1.7, true);

        // Act
        person.Address = new Address("Stockholmsvägen", 1, "Stockholm", 12345);

        // Assert
        Assert.NotNull(person.Address);
        Assert.Equal("Stockholmsvägen", person.Address.Street);
    }
}