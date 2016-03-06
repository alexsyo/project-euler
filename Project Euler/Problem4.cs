using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    /**
    * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    * Find the largest palindrome made from the product of two 3-digit numbers.
    */
    public class Problem4 : Problem
    {
        public override double Solve(double variable)
        {
            int min = SetMin(variable);
            int a = min;
            double palindrome = 0;

            while(a.ToString().Length <= variable)
            {
                int b = min;

                while (b.ToString().Length <= variable)
                {
                    int product = a * b;

                    if (product > palindrome && IsPalindrome(product))
                    {
                        palindrome = product;
                    }

                    b++;
                }

                a++;
            }

            return palindrome;
        }


        private static int SetMin(double n)
        {
            string min = "1";

            for (int i = 1; i < n; i++)
            {
                min += "0";
            }

            return Int32.Parse(min);
        }

        private static bool IsPalindrome(int product)
        {
            string number = product.ToString();

            for(int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - i - 1]) return false;
            }

            return true;
        }
    }
}
