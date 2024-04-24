using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
    // https://www.interviewkickstart.com/blog/interview-questions/intel-interview-questions
    Given an unsorted set of numbers from 1 to N with exactly two of them missing, find those 2 missing numbers.
    * Number is continuous *

   Example
   Input: new int[] {6,3,2,7,1,4}
   Output: 5,8

   Method:
   1. Flip whole string and the flip the text again
   2. Split string by "space" and reverse the array to string
   3. Loop string character one by one
    */

    internal class Q02
    {
        static void Main(string[] args)
        {
            int[] randomNum = new int[] {6, 3, 1, 2, 4 };
            Console.WriteLine("Input string: " + string.Join(", ", randomNum));

            int sum = 0; // sum of all number + 2
            int offset = 0; // sum of missing 2 integer

            for (int i = 1; i <= randomNum.Count() + 2; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("sum: " + sum.ToString());

            offset = sum;
            for (int i = 0; i < randomNum.Count(); i++)
            {
                offset = offset - randomNum[i];
            }

            // we find the average and store sum of first average numbers
            int average = offset / 2;
            Console.WriteLine("avg: " + average.ToString());

            int sum_avg = 0;
            for (int i = 1; i <= average; i++)
            {
                sum_avg = sum_avg + i;
            }
            Console.WriteLine("sum_avg: " + sum_avg.ToString());

            //sum of all numbers from arr less than average
            int x = 0;
            for (int i = 0; i < randomNum.Count(); i++)
            {
                if (randomNum[i] <= average)
                {
                    x = x + randomNum[i];
                }
            }
            Console.WriteLine("x: " + x.ToString());

            // the resuls sum_avg - x gives the smaller missing number
            int missingNum1 = sum_avg - x;
            int missingNum2 = offset - missingNum1;

            Console.WriteLine("Num1: " + missingNum1.ToString());
            Console.WriteLine("Num2: " + missingNum2.ToString());

            Console.ReadLine();
        }
    }
}
