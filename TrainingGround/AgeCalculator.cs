public class AgeCalculator
{
    public static int CalculateAge(int currentYear, int birthYear)
    {
        if (birthYear < 0)
        {
            throw new Exception("Person can't be born before year 0");
        }

        else if (birthYear > currentYear)
        {
            throw new Exception("Not born yet");
        }

        return currentYear - birthYear;
    }
}