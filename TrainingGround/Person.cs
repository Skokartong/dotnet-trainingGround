public class Person
{
    public string Name { get; private set; }
    public int BirthYear { get; private set; }
    public double HeightInMeters { get; private set; }
    public List<Address?> Addresses { get; private set; }
    public AgeGroup AgeGroup { get; set; }

    public Person(string name, int birthYear, double heightInMeters)
    {
        ValidationCheck(name, birthYear, heightInMeters);
        Name = name;
        BirthYear = birthYear;
        HeightInMeters = heightInMeters;
        Addresses = new List<Address?>();
    }

    // Fail early: validate input parameters so object is always in a valid state
    private void ValidationCheck(string name, int birthYear, double heightInMeters)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new Exception("Name can't be empty");
        }

        if (birthYear < 0)
        {
            throw new Exception("Person can't be born before year 0");
        }

        if (birthYear > DateTime.Now.Year)
        {
            throw new Exception("Not born yet");
        }

        if (heightInMeters <= 0)
        {
            throw new Exception("Height must be a positive number");
        }
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