using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarFinder.Helpers
{
    public sealed class ThreadLocalRandom
    {
        static int seed = Environment.TickCount;

        static readonly ThreadLocal<Random> _Random =
            new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref seed)));

        /// <summary>See </summary> 
        public static int Next(int minValue, int maxValue)
        {
            return _Random.Value.Next(minValue, maxValue);
        }

      

    }
}
