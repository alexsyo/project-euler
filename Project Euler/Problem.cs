using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public abstract class Problem
    {
        /// <summary>
        /// Solve the problem using the given variable
        /// </summary>
        /// <param name="variable"></param>
        /// <returns></returns>
        public abstract double Solve(double variable);
    }
}
