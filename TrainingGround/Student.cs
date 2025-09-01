public class Student : Person
{
    public string StudentId { get; private set; }

    public Student(string name, int birthYear, double heightInMeters, string studentId)
        : base(name, birthYear, heightInMeters)
    {
        StudentId = studentId;
    }
}