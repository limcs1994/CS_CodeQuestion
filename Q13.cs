using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
    How would you implement Binary Search
    - Binary search divides the array into half in every iteration step until it finds the element.
    - It works on the sorted arrays since it compares the values of adjacent elements and then calculates the mid number.
    - If the value of low becomes greater than high at any point, it means the element is not present in the list.
    */
    internal class Q13
    {
        static void Main(string[] args)
        {
            int[] numArr = new int[] { 2, 5, 7, 8, 9, 11, 14, 15, 18, 20 };
            int targetNum = 14;
            int targetIndex = -1;
            int leftIndex = 0;
            int rightIndex = numArr.Length - 1;

            Console.WriteLine(string.Format("Number array: {0}", string.Join(", ", numArr)));
            Console.WriteLine("Target number: " + targetNum);

            while (leftIndex <= rightIndex)
            {
                int mid = 0;
                
                mid = leftIndex + ((rightIndex - leftIndex) / 2);
                //Console.WriteLine("--- Right: " + rightIndex);
                //Console.WriteLine("--- Left: " + leftIndex);
                //Console.WriteLine("--- Mid: " + mid);

                if (numArr[mid] == targetNum)
                {
                    targetIndex = mid;
                    break;
                }
                else if (targetNum > numArr[mid])
                {
                    // target at right side
                    leftIndex = mid + 1;
                }
                else
                {
                    // target at left side
                    rightIndex = mid - 1;
                }
            }

            Console.WriteLine("Index of target number in array is " + targetIndex);
            Console.ReadLine();
        }
    }
}
