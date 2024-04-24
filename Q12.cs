using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{

    /*
    How do you find the factorial of an integer using recursion

   Example
   input: 5!= 5*4*3*2*1
   Output: 120
   */

    internal class Q12
    {
        static void Main(string[] args)
        {
            int inputInt = 5;
            Console.WriteLine("inputInt: " + inputInt.ToString());
            Console.WriteLine("Factorial: " + factorial(inputInt).ToString());
            Console.ReadLine();
        }

        private static int factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * factorial(num - 1);
        }
    }
}
