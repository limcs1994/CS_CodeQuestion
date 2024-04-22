using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
   Print fibonacci using recursive

  Example
  Output: 0,1,1,2,3,5,8,13,21, ...
   */

    internal class Q3
    {
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                sb.Append(fibonacci(i).ToString()).Append(",");
            }

            Console.WriteLine(string.Format("First {0} fibonacci number: {1}", 10, sb.ToString()));
            Console.ReadLine();
        }

        private static int fibonacci(int n)
        {
            if (n <= 1)
            {
                //Console.WriteLine("return " + n.ToString());
                return n;
            }
            else
            {
                int num1 = fibonacci(n - 1);
                int num2 = fibonacci(n - 2);
                //Console.WriteLine(string.Format("Num1: {0}   Num2: {1}", num1.ToString(), num2.ToString()));
                //Console.WriteLine("return " + (num1 + num2).ToString());
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
    }
}
