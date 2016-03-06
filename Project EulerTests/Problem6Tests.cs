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
    public class Problem6Tests
    {
        [TestMethod()]
        public void SolveTest()
        {
            Problem6 problem6 = new Problem6();

            double expected = 2640;
            double actual = problem6.Solve(10);

            Assert.AreEqual(expected, actual);
        }
    }
}