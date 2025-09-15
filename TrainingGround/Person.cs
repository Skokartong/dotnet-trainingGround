public class Person
{
    public string? Name { get; private set; }
    public int BirthYear { get; private set; }
    public double HeightInMeters { get; private set; }
    public List<Address?> Addresses { get; private set; }
    public AgeGroup AgeGroup { get; set; }

    public Person(string name, int birthYear, double heightInMeters)
    {
        Name = name;
        BirthYear = birthYear;
        HeightInMeters = heightInMeters;
        Addresses = new List<Address?>();
    }

    // Overlayering constructor to create person using age instead of birth year
    public Person(string name, int age, double heightInMeters, bool isAge)
    {
        Name = name;
        BirthYear = DateTime.Now.Year - age;
        HeightInMeters = heightInMeters;
        Addresses = new List<Address?>();
    }

    public int GetAge()
    {
        var currentYear = DateTime.Now.Year;
        var age = currentYear - BirthYear;

        if (age < 0)
        {
            throw new Exception("Not born yet");
        }

        else if (BirthYear < 0)
        {
            throw new Exception("Person can't be born before year 0");
        }

        return age;
    }

    public void SetAgeGroup()
    {
        var age = GetAge();
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

    public static string GetAgeGroup(AgeGroup ageGroup)
    {
        switch (ageGroup)
        {
            case AgeGroup.Child:
                return "Just a child!";
            case AgeGroup.Teen:
                return "Teenager...";
            case AgeGroup.Adult:
                return "Adult in the prime of life";
            case AgeGroup.Senior:
                return "Person with experience";
            default:
                return "Unknown";
        }
    }
}