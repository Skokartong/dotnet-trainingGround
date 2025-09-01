public class Student : Person
{
    public string StudentId { get; private set; }

    public Student(string name, int birthYear, double heightInMeters, string studentId, Address? address = null)
        : base(name, birthYear, heightInMeters, address)
    {
        StudentId = studentId;
    }
}