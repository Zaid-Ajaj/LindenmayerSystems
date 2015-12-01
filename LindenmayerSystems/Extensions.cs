using System;
using System.Collections.Generic;

namespace LindenmayerSystems
{
    // Helper functions
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> work)
        {
            foreach (var item in source)
                work(item);
        }

        public static T Nest<T>(Func<T, T> f, T x, int n)
        {
            if (n <= 0)
                return x;
            else
                return Nest(f, f(x), n - 1);
        }

        public static T NestFast<T>(Func<T,T> f, T x, int n)
        {
            var result = x;
            while (n > 0)
                result = f(result);
            return result;
        }
    }
}
