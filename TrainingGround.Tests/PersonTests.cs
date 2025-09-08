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
        person.Address = new Address("Stockholmsvägen", 1, "Stockholm", 12345);

        student = new Student("Torbjörn", 1999, 1.8, "12345");
        student.Address = new Address("Malmövägen", 2, "Malmö", 54321);
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
        var age = person.GetAge(currentYear);

        // Assert
        Assert.Equal(currentYear - person.BirthYear, age);
    }

    [Fact]
    public void a_person_has_an_adress()
    {
        // Assert
        Assert.NotNull(person.Address);
        Assert.IsType<Address>(person.Address);

        Assert.Equal("Stockholmsvägen", person.Address.Street);
        Assert.Equal(1, person.Address.StreetNumber);
        Assert.Equal("Stockholm", person.Address.City);
        Assert.Equal(12345, person.Address.ZipCode);
    }

    [Fact]
    public void a_student_gets_a_nice_printed_address()
    {
        // Act
        var printedAddress = student.Print();
        var expected = $"Student ID: 12345, Name: Torbjörn, Birth Year: 1999, Height: 1.8m, Address: Malmövägen 2, 54321 Malmö";

        // Assert
        Assert.Equal(expected, printedAddress);
    }

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
}