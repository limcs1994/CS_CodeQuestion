using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
     Create a function that can accept varying numbers of arguments
     */
    internal class Q20
    {
        static void Main(string[] args)
        {
            int math1 = Add(1, 2, 3, 4, 5);
            int math2 = Add(10, 11);

            Console.WriteLine("Answer for math1 is " + math1.ToString());
            Console.WriteLine("Answer for math2 is " + math2.ToString());
            Console.ReadLine();
        }

        private static int Add(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum = sum + number;
            }

            return sum;
        }
    }
}
