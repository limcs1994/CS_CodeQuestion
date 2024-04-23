using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
    How do you reverse an array without create another thrid temporary array vriable

      Example
      input: 1, 2, 7, 6, 4, 9, 12
      Output: 12, 9, 4, 6, 7, 2, 1
      */

    internal class Q10
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Input list: " + string.Join(", ", inputList));

            for (int i = 0; i < inputList.Count() / 2; i++)
            {
                int tempInt = inputList[i];
                inputList[i] = inputList[inputList.Count() - i - 1];
                inputList[inputList.Count() - i - 1] = tempInt;
            }

            Console.WriteLine("Reverse list: " + string.Join(", ", inputList));
            Console.ReadLine();
        }
    }
}
