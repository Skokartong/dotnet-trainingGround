using System.Linq;
public class Student : Person, IPrintable
{
    public string StudentId { get; private set; }

    public Student(string name, int birthYear, double heightInMeters, string studentId)
        : base(name, birthYear, heightInMeters)
    {
        StudentId = studentId;
    }

    public string Print()
    {
        // Linq to format addresses, handling potential nulls
        var formattedAddresses = string.Join("; ", Addresses
        .Where(a => a != null)
        .Select(a => $"{a?.Street} {a?.StreetNumber}, {a?.ZipCode} {a?.City}"));

        var result = $"Student ID: {StudentId}, Name: {Name}, Birth Year: {BirthYear}, Height: {HeightInMeters.ToString(System.Globalization.CultureInfo.InvariantCulture)}m, Address/Addresses: {formattedAddresses}";
        return result;
    }
}