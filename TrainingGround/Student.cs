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
        var result = $"Student ID: {StudentId}, Name: {Name}, Birth Year: {BirthYear}, Height: {HeightInMeters.ToString(System.Globalization.CultureInfo.InvariantCulture)}m, Address: {Address?.Street} {Address?.StreetNumber}, {Address?.ZipCode} {Address?.City}";
        return result;
    }
}