public class Student : Person, IPrintable
{
    public string StudentId { get; private set; }

    public Student(string name, int birthYear, double heightInMeters, string studentId, Address? address = null)
        : base(name, birthYear, heightInMeters, address)
    {
        StudentId = studentId;
    }

    public void Print()
    {
        Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Birth Year: {BirthYear}, Height: {HeightInMeters}m, Address: {Address?.Street} {Address?.StreetNumber}, {Address?.ZipCode} {Address?.City}");
    }
}