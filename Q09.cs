using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
    How would you implement the insertion sort algorithm

    Example
    input: 2,5,1,3,6,4
    Output: 1,2,3,4,5,6
    */
    internal class Q09
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int>() { 6, 3, 2, 7, 4, 9, 1 };

            Console.WriteLine(string.Join(", ", inputList));

            for (int i = 1; i < inputList.Count(); ++i)
            {
                int key = inputList[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && inputList[j] > key)
                {
                    //Console.WriteLine(string.Format("Insert {0} from index {1} to {2}", inputList[j], j, j +1));
                    inputList[j + 1] = inputList[j];
                    j = j - 1;
                }
                inputList[j + 1] = key;

                Console.WriteLine(string.Join(", " , inputList));
            }

            Console.ReadLine();
        }
    }
}
