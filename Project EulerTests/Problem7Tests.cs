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
    public class Problem7Tests
    {
        [TestMethod()]
        public void SolveTest()
        {
            Problem7 problem7 = new Problem7();

            double expected = 13;
            double actual = problem7.Solve(6);

            Assert.AreEqual(expected, actual);
        }
    }
}