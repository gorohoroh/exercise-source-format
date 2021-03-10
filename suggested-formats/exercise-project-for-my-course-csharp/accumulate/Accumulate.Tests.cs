using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Accumulate
{
    public class AccumulateTests
    {
        [Fact]
        public void Empty_accumulation_produces_empty_accumulation()
        {
            Assert.Equal(new int[0], AccumulateExtensions.Accumulate(new int[0], x => x * x));
        }

        [Fact]
        public void Accumulate_squares()
        {
            Assert.Equal(new[] { 1, 4, 9 }, AccumulateExtensions.Accumulate(new[] { 1, 2, 3 }, x => x * x));
        }

        [Fact]
        public void Accumulate_upcases()
        {
            Assert.Equal(new List<string> { "HELLO", "WORLD" }, AccumulateExtensions.Accumulate(new List<string> { "hello", "world" }, x => x.ToUpper()));
        }

        [Fact]
        public void Accumulate_reversed_strings()
        {
            Assert.Equal("eht kciuq nworb xof cte".Split(' '), AccumulateExtensions.Accumulate("the quick brown fox etc".Split(' '), Reverse));
        }

        private static string Reverse(string value)
        {
            var array = value.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        [Fact]
        public void Accumulate_within_accumulate()
        {
            var actual = AccumulateExtensions.Accumulate(new[] { "a", "b", "c" }, c =>
                string.Join(" ", AccumulateExtensions.Accumulate(new[] { "1", "2", "3" }, d => c + d)));
            Assert.Equal(new[] { "a1 a2 a3", "b1 b2 b3", "c1 c2 c3" }, actual);
        }

        [Fact]
        public void Accumulate_is_lazy()
        {
            var counter = 0;
            var accumulation = AccumulateExtensions.Accumulate(new[] { 1, 2, 3 }, x => x * counter++);

            Assert.Equal(0, counter);
            accumulation.ToList();
            Assert.Equal(3, counter);
        }

        [Fact]
        public void Accumulate_allows_different_return_type()
        {
            Assert.Equal(new[] { "1", "2", "3" }, AccumulateExtensions.Accumulate(new[] { 1, 2, 3 }, x => x.ToString()));
        }
    }
}