using Xunit;

public class LeapTestsInstruction1
{
    [Fact] public void Integer_2000_not_divisible_by_3() => Assert.False(2000.IsDivisibleBy(3));
    [Fact] public void Integer_1999_not_divisible_by_4() => Assert.False(1999.IsDivisibleBy(4));
    [Fact] public void Integer_2044_is_divisible_by_4() => Assert.True(2044.IsDivisibleBy(4));
}
