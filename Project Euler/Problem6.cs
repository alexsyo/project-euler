using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem6 : Problem
    {
        public override double Solve(double variable)
        {
            double squareOfSums = 0;
            double sumOfSquares = 0;

            for(double i = 1; i <= variable; i ++)
            {
                sumOfSquares += i * i;
                squareOfSums += i;
            }

            squareOfSums *= squareOfSums;

            return squareOfSums - sumOfSquares;
        }
    }
}
