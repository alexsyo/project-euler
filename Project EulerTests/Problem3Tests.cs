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
    public class Problem3Tests
    {
        [TestMethod()]
        public void SolveTest()
        {
            Problem3 problem3 = new Problem3();

            double expected = 29;
            double actual = problem3.Solve(13195);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsPrimeFactorTest()
        {
            Assert.AreEqual(true, Problem3.IsPrimeFactor(3, new List<double> { 2 }));
            Assert.AreEqual(true, Problem3.IsPrimeFactor(5, new List <double> { 2, 3 }));
            Assert.AreEqual(false, Problem3.IsPrimeFactor(15, new List <double> { 2, 3, 5, 7, 11, 13 }));
            Assert.AreEqual(false, Problem3.IsPrimeFactor(16, new List <double> { 2, 3, 5, 7, 11, 13 }));
        }
    }
}