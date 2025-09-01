public class Person
{
    public string? Name { get; private set; }
    public int BirthYear { get; private set; }
    public double HeightInMeters { get; private set; }

    public Person(string name, int birthYear, double heightInMeters)
    {
        Name = name;
        BirthYear = birthYear;
        HeightInMeters = heightInMeters;
    }

    // Overlayering constructor to create person using age instead of birth year
    public Person(string name, int age, double heightInMeters, bool isAge)
    {
        Name = name;
        BirthYear = DateTime.Now.Year - age;
        HeightInMeters = heightInMeters;
    }

    public int GetAge(int currentYear)
    {
        return currentYear - BirthYear;
    }
}