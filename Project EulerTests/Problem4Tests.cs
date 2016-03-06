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
    public class Problem4Tests
    {
        [TestMethod()]
        public void SolveTest()
        {
            Problem4 problem4 = new Problem4();

            double expected = 9009;
            double actual = problem4.Solve(2);

            Assert.AreEqual(expected, actual);
        }
    }
}