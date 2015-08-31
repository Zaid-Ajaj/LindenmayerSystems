using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
