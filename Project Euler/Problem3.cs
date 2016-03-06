using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    /// <summary>
    ///
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// 
    /// </summary>
    public class Problem3 : Problem
    {
        public override double Solve(double variable)
        {
            double i = 2;
            List<double> primeFactors = new List<double> { };
            double highestPrimeFactor = 1;

            while (variable != 1)
            {
                if(IsPrimeFactor(i, primeFactors))
                {
                    primeFactors.Add(i);

                    if ((variable / i) % 1 == 0)
                    {
                        variable /= i;
                        highestPrimeFactor = i;
                        continue;
                    }
                }

                i++;
            }

            return highestPrimeFactor;
        }

        public static bool IsPrimeFactor(double n, List<double> PrimeFactors)
        {
            foreach(double PrimeFactor in PrimeFactors)
            {
                double division = n / PrimeFactor;

                if (division % 1 == 0) return false;
            }

            return true;
        }
    }
}
