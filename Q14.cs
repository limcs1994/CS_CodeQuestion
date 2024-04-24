using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
    How would you find the second largest number in an array

    Example
    input: 3,6,1,7,3,8,9,11,2
    Output: 9
    */

    internal class Q14
    {
        static void Main(string[] args)
        {
            int largestNum = 0;
            int secLargestNum = 0;
            int[] inputArr = new int[] { 3, 6, 1, 7, 3, 8, 9, 11, 2 };

            Console.WriteLine(string.Format("Input array: {0}", string.Join(", ", inputArr)));

            foreach (int num in inputArr)
            {
                if (num > largestNum)
                {
                    secLargestNum = largestNum;
                    largestNum = num;
                }
            }

            Console.WriteLine("Largest number: " + largestNum.ToString());
            Console.WriteLine("Second largest number: " + secLargestNum.ToString());
            Console.ReadLine();
        }
    }
}
