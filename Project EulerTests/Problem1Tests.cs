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
    public class Problem1Tests
    {
        [TestMethod()]
        public void SolveTest()
        {
            Problem1 problem1 = new Problem1();

            double expected = 23;
            double actual = problem1.Solve(10);

            Assert.AreEqual(expected, actual);
        }
    }
}