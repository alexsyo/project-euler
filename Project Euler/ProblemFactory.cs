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
