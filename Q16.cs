using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
        Sort array of character using swap method
   */

    internal class Q16
    {
        static void Main(string[] args)
        {
            char[] charArr = new char[] { 'a', 'd', 'b', 'e', 'c' };
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;

                //Sorting
                for (int i = 0; i < charArr.Length - 1; i++)
                {
                    if (Convert.ToInt32(charArr[i]) > Convert.ToInt32(charArr[i + 1]))
                    {
                        //Swap
                        char temp = charArr[i];
                        charArr[i] = charArr[i + 1];
                        charArr[i + 1] = temp;

                        isSorted = false;
                    }
                }
            }

            Console.WriteLine("Sorted: " + string.Join(", ", charArr));
            Console.ReadLine();
        }
    }
}
