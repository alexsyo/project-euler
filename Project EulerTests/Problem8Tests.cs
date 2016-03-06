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
    public class Problem8Tests
    {
        [TestMethod()]
        public void SolveTest()
        {
            Problem8 problem8 = new Problem8();

            double expected = 5832;
            double actual = problem8.Solve(4);

            Assert.AreEqual(expected, actual);
        }
    }
}