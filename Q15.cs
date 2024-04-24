using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
    How do you check if the given number is prime

    Example
    input: 2
    Output: Is Prime

    input: 4
    Output: Not Prime
    */

    internal class Q15
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int inputNum = 9;
            Console.WriteLine(string.Format("Input number: {0}", inputNum));

            for (int i = 2; i < inputNum; i++)
            {
                if (inputNum % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime? "Is Prime number" : "Not a Prime number");
            Console.ReadLine();
        }
    }
}
