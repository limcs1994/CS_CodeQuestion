using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
    How would you swap two numbers without using a third variable

   Example
   input: a = 5, b =10
   Output: a = 10, b =5
   */

    internal class Q11
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;

            Console.WriteLine(string.Format("Input num1: {0} , num2: {1}", num1.ToString(), num2.ToString()));
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine(string.Format("Swapped num1: {0} , num2: {1}", num1.ToString(), num2.ToString()));
            Console.ReadLine();
        }
    }
}
