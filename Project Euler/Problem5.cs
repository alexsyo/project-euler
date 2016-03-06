using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    /// <summary>
    /// 
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// 
    /// </summary>
    public class Problem5 : Problem
    {
        public override double Solve(double variable)
        {
            List<double> evenDivisors = FindEvenDivisors(variable);
            double smallestMultiple = Multiply(evenDivisors);

            return smallestMultiple;
        }


        private static List<double> FindEvenDivisors(double max)
        {
            List<double> primeFactors = new List<double> { };

            for (double i = 2; i <= max; i++)
            {
                if (Problem3.IsPrimeFactor(i, primeFactors))
                {
                    primeFactors.Add(i);
                }
                else
                {
                    List<double> nPrimeFactors = FindPrimeFactors(i, primeFactors);
                    primeFactors = AddMissingFactors(nPrimeFactors, primeFactors);
                }
            }

            return primeFactors;
        }

        public static List<double> FindPrimeFactors(double n, List<double> primeFactors)
        {
            List<double> nPrimeFactors = new List<double> { };
            int i = 0;

            while(n != 1)
            {

                if((n / primeFactors[i]) % 1 == 0)
                {
                    nPrimeFactors.Add(primeFactors[i]);
                    n /= primeFactors[i];
                    continue;
                }

                i++;
            }

            return nPrimeFactors;
        }

        private static List<double> AddMissingFactors(List<double> nPrimeFactors, List<double> primeFactors)
        {
            List<double> unique = nPrimeFactors.Distinct().ToList();

            unique.ForEach(x => {
                int CountNPrimeFactors = nPrimeFactors.FindAll(i => i == x).Count();
                int CountPrimeFactors = primeFactors.FindAll(i => i == x).Count();

                if(CountNPrimeFactors > CountPrimeFactors)
                {
                    primeFactors.Add(x);
                }
            });

            return primeFactors;
        }

        private static double Multiply(List<double> divisors)
        {
            double product = 1;

            foreach(int divisor in divisors)
            {
                product *= divisor;
            }

            return product;
        }
    }
}
