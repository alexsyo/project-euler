using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Project_Euler
{
    public class ProblemFactory
    {
        /// <summary>
        /// Instantiate the {index} problem and print the solution on the console using the given variable
        /// </summary>
        /// <param name="index"></param>
        /// <param name="var"></param>
        public static void Print(int index, double var)
        {
            string className = "Project_Euler.Problem" + index;
            Type type = Type.GetType(className);
            Problem problem = (Problem)Activator.CreateInstance(type);

            double solution = problem.Solve(var);

            Console.WriteLine("Problem {0}: {1}", index, solution);
        }
    }
}
