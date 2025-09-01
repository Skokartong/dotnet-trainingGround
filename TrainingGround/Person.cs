public class Person
{
    public string? Name { get; private set; }
    public int BirthYear { get; private set; }
    public double HeightInMeters { get; private set; }
    public Address? Address { get; set; }
    public AgeGroup AgeGroup { get; set; }

    public Person(string name, int birthYear, double heightInMeters, Address? address = null)
    {
        Name = name;
        BirthYear = birthYear;
        HeightInMeters = heightInMeters;
        Address = address;
    }

    // Overlayering constructor to create person using age instead of birth year
    public Person(string name, int age, double heightInMeters, bool isAge, Address? address = null)
    {
        Name = name;
        BirthYear = DateTime.Now.Year - age;
        HeightInMeters = heightInMeters;
        Address = address;
    }

    public int GetAge(int currentYear)
    {
        return currentYear - BirthYear;
    }

    public void SetAgeGroup()
    {
        var age = GetAge(DateTime.Now.Year);
        if (age < 13)
        {
            AgeGroup = AgeGroup.Child;
        }
        else if (age < 20)
        {
            AgeGroup = AgeGroup.Teen;
        }
        else if (age < 65)
        {
            AgeGroup = AgeGroup.Adult;
        }
        else
        {
            AgeGroup = AgeGroup.Senior;
        }
    }
}