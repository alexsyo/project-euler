using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    /// <summary>
    /// 
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10 001st prime number?
    /// 
    /// </summary>
    public class Problem7 : Problem
    {
        public override double Solve(double variable)
        {
            double i = 2;
            List <double> primeFactors = new List<double> { };

            while(primeFactors.Count < variable)
            {
                if(Problem3.IsPrimeFactor(i, primeFactors))
                {
                    primeFactors.Add(i);
                }

                i++;
            }

            return primeFactors.Last();
        }
    }
}
