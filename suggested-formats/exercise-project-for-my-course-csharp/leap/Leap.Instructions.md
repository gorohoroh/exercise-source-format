# Instructions

Given a year, report if it is a leap year.

The tricky thing here is that a leap year in the Gregorian calendar occurs:

```text
on every year that is evenly divisible by 4
  except every year that is evenly divisible by 100
    unless the year is also evenly divisible by 400
```

For example, 1997 is not a leap year, but 1996 is. 1900 is not a leap
year, but 2000 is.

## Instruction 1
Start by writing an extension method that checks if a given integer is leap:
```csharp
private static bool IsDivisibleBy(this int i, int divisor) => i % divisor == 0;
```

## Instruction 2
Update body of the `IsLeapYear(int year)` method to check if the current year is evenly divisible by 400, 100, and 4, in this particular order: 
```csharp
public static bool IsLeapYear(int year)
{
    if (year.IsDivisibleBy(400)) return true;
    if (year.IsDivisibleBy(100)) return false;
    if (year.IsDivisibleBy(4)) return true;
    return false;
}
```

## Notes

Though our exercise adopts some very simple rules, there is more to
learn!

For a delightful, four minute explanation of the whole leap year
phenomenon, go watch [this youtube video][video].

[video]: http://www.youtube.com/watch?v=xX96xng7sAE

The DateTime class in C# provides a built-in [IsLeapYear](https://msdn.microsoft.com/en-us/library/system.datetime.isleapyear(v=vs.110).aspx) method
which you should pretend doesn't exist for the purposes of implementing this exercise.
