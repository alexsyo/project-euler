using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{

    /*
    * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    * the sum of all the multiples of 3 or 5 below 1000.
    */
    public class Problem1 : Problem
    {
        public override double Solve(double variable)
        {
            double sum = 0;

            for(double i = 0; i < variable; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
