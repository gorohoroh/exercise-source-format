using Xunit;

public class LeapTests
{
    public class Instruction1
    {
        [Fact] public void Integer_2000_not_divisible_by_3() => Assert.False(2000.IsDivisibleBy(3));
        [Fact] public void Integer_1999_not_divisible_by_4() => Assert.False(1999.IsDivisibleBy(4));
        [Fact] public void Integer_2044_is_divisible_by_4() => Assert.True(2044.IsDivisibleBy(4));
    }

    public class Instruction2
    {
        [Fact]
        public void Year_not_divisible_by_4_in_common_year()
        {
            Assert.False(Leap.IsLeapYear(2015));
        }

        [Fact]
        public void Year_divisible_by_2_not_divisible_by_4_in_common_year()
        {
            Assert.False(Leap.IsLeapYear(1970));
        }

        [Fact]
        public void Year_divisible_by_4_not_divisible_by_100_in_leap_year()
        {
            Assert.True(Leap.IsLeapYear(1996));
        }

        [Fact]
        public void Year_divisible_by_4_and_5_is_still_a_leap_year()
        {
            Assert.True(Leap.IsLeapYear(1960));
        }

        [Fact]
        public void Year_divisible_by_100_not_divisible_by_400_in_common_year()
        {
            Assert.False(Leap.IsLeapYear(2100));
        }

        [Fact]
        public void Year_divisible_by_100_but_not_by_3_is_still_not_a_leap_year()
        {
            Assert.False(Leap.IsLeapYear(1900));
        }

        [Fact]
        public void Year_divisible_by_400_in_leap_year()
        {
            Assert.True(Leap.IsLeapYear(2000));
        }

        [Fact]
        public void Year_divisible_by_400_but_not_by_125_is_still_a_leap_year()
        {
            Assert.True(Leap.IsLeapYear(2400));
        }

        [Fact]
        public void Year_divisible_by_200_not_divisible_by_400_in_common_year()
        {
            Assert.False(Leap.IsLeapYear(1800));
        }
    }
}