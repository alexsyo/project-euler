using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Tests
{
    [TestClass()]
    public class Problem2Tests
    {
        [TestMethod()]
        public void SolveTest()
        {
            Problem2 problem2 = new Problem2();

            double expected = 2 + 8 + 34;
            double actual = problem2.Solve(100);

            Assert.AreEqual(expected, actual);
        }
    }
}