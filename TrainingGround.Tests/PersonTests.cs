using Xunit;

namespace TrainingGround.Tests;

public class PersonTests
{
    private Person person;
    private Student student;

    // Arrange - common setup for all tests
    public PersonTests()
    {
        person = new Person("Hilda", 1972, 1.7);
        person.Addresses.Add(new Address("Stockholmsvägen", 1, "Stockholm", 12345));

        student = new Student("Torbjörn", 1999, 1.8, "12345");
        student.Addresses.Add(new Address("Malmövägen", 2, "Malmö", 54321));
    }

    [Fact]
    public void create_person_with_constructor()
    {
        // Assert
        Assert.NotNull(person);
    }

    [Fact]
    public void create_student_with_constructor()
    {
        // Assert
        Assert.NotNull(student);
    }

    [Fact]
    public void get_age_returns_correct_age()
    {
        // Arrange
        var currentYear = DateTime.Now.Year;

        // Act
        var age = person.GetAge();

        // Assert
        Assert.Equal(currentYear - person.BirthYear, age);
    }

    [Fact]
    public void a_person_has_an_adress()
    {
        // Assert
        Assert.NotNull(person.Addresses);
        Assert.IsType<Address>(person.Addresses[0]);

        Assert.Equal("Stockholmsvägen", person.Addresses[0]?.Street);
        Assert.Equal(1, person.Addresses[0]?.StreetNumber);
        Assert.Equal("Stockholm", person.Addresses[0]?.City);
        Assert.Equal(12345, person.Addresses[0]?.ZipCode);
    }

    [Fact]
    public void a_student_gets_a_nice_printed_address()
    {
        // Act
        var printedAddress = student.Print();
        var expected = $"Student ID: 12345, Name: Torbjörn, Birth Year: 1999, Height: 1.8m, Address/Addresses: Malmövägen 2, 54321 Malmö";

        // Assert
        Assert.Equal(expected, printedAddress);
    }
}