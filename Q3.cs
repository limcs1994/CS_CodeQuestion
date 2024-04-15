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
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(fibonacci(i).ToString() + ", ");
            }

            Console.ReadLine();
        }

        private static int fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
    }
}
