using System;
using Xunit;
using NukeSolver;

namespace NukeTest
{
    public class UnitTests
    {
        // Nuke rows are http://oeis.org/A000124
        // 1st in row #1 = 1, #2 = 2, #3 = 4, #4 = 7, #5 = 11, #6 = 16, #7 = 22, #8 = 29, #9 = 37, #10 = 46,
        //            #11 = 56, #12 = 67, #13 = 79, #14 = 92, #15 = 106, #16 = 121

        [Fact]
        public void BasicTest()
        {
            Assert.Equal(1, SolverApp.Process("1"));
            Assert.Equal(2, SolverApp.Process("2"));
            Assert.Equal(4, SolverApp.Process("7"));
            Assert.Equal(9, SolverApp.Process("40"));
            Assert.Equal(14, SolverApp.Process("100"));
        }

        [Fact]
        public void TestLevel8Boundaries()
        {
            Assert.Equal(7, SolverApp.Process("28"));
            Assert.Equal(8, SolverApp.Process("29"));
            Assert.Equal(8, SolverApp.Process("36"));
            Assert.Equal(9, SolverApp.Process("37"));
        }

        [Fact]
        public void TestInputValueBoundaries()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => SolverApp.Process("-10"));
            Assert.Throws<ArgumentOutOfRangeException>(() => SolverApp.Process("0"));
            Assert.Equal(1, SolverApp.Process("1"));
            Assert.Equal(15, SolverApp.Process("108"));
            Assert.Throws<ArgumentOutOfRangeException>(() => SolverApp.Process("109"));
        }

        [Fact]
        public void TestInputFormat()
        {
            Assert.Throws<FormatException>(() => SolverApp.Process("aaaa"));
        }
    }
}
