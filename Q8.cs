using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
    How would you implement the bubble sort algorithm

    Example
    input: 2,5,1,3,6,4
    Output: 1,2,3,4,5,6
    */

    internal class Q8
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int>() { 3, 2, 8, 4, 1, 6 };
            bool isClean = false;

            Console.WriteLine("Unsorted: " + string.Join(", ", inputList));

            while (!isClean)
            {
                isClean = true;

                for (int i = 0; i < inputList.Count - 1; i++)
                {
                    if (inputList[i] > inputList[i + 1])
                    {
                        int temp = inputList[i + 1];
                        inputList[i + 1] = inputList[i];
                        inputList[i] = temp;
                        isClean = false;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (int num in inputList)
            {
                sb.Append(num.ToString()).Append(", ");
            }

            Console.WriteLine("Sorted: " + sb.ToString());
            Console.ReadLine();
        }
    }
}
