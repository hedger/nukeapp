using System;

namespace NukeSolver
{
    static class Solver
    {
        /// Note: sequence of first elements in each row is A000124, Central polygonal numbers 
        /// http://oeis.org/A000124
        /// E = n(n+1) / 2 + 1
        /// Positive root of equation = -1 + sqrt(1 + 4 * 2 * (E - 1))
        static public int GetLevel(int nukeNumber)
        {
            if (nukeNumber <= 0)
                throw new ArgumentException(nameof(nukeNumber));

            return (int)(1 + Math.Floor((-1 + Math.Sqrt(1 + 8 * (nukeNumber - 1))) / 2));
        }

        static public int GetLevelConstrained(int nukeNumber, int minVal, int maxVal)
        {
            if ((nukeNumber < minVal) || (nukeNumber > maxVal))
                throw new ArgumentOutOfRangeException(nameof(nukeNumber));

            return GetLevel(nukeNumber);
        }
    }
}
