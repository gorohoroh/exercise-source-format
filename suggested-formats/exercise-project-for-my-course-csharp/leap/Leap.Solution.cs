public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if (year.IsDivisibleBy(400)) return true;
        if (year.IsDivisibleBy(100)) return false;
        if (year.IsDivisibleBy(4)) return true;
        return false;
    }

    private static bool IsDivisibleBy(this int i, int divisor) => i % divisor == 0;
}
