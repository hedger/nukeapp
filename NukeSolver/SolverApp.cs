using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("NukeTest")]
namespace NukeSolver
{
    class SolverApp
    {
        const int MIN_NUKE = 1;
        const int MAX_NUKE = 108;

        static public void Main(string[] args)
        {
            Console.WriteLine(Process(Console.ReadLine()));
        }

        // Expects valid input, throws exception otherwise
        static public int Process(string input)
        {
            int nukeNumber = Int32.Parse(input);
            return Solver.GetLevelConstrained(nukeNumber, minVal: MIN_NUKE, maxVal: MAX_NUKE);
        }
    }
}
