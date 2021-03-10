using System;
using System.Collections.Generic;

namespace Accumulate
{
    public static class AccumulateExtensionsSolution
    {
        public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
        {
            foreach (var item in collection)
                yield return func(item);
        }
    }
}