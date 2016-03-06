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
    public class Problem5Tests
    {
        [TestMethod()]
        public void SolveTest()
        {
            Problem5 problem5 = new Problem5();

            double expected = 2520;
            double actual = problem5.Solve(10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindPrimeFactorsTest()
        {
            List<double> expected = new List<double> { 2, 2, 2, 3, 3, 7 };
            List<double> actual = Problem5.FindPrimeFactors(504, new List<double> { 2, 3, 5, 7, 11, 13});

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}