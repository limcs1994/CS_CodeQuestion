using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
     How do you determine if a string is a palindrome

    Example
    input: abba
    Output: palindrome

    input: ablba
    Output: palindrome

    input: ablbal
    Output: non-palindrome
*/

    internal class Q05
    {
        static void Main(string[] args)
        {
            string inputStr = "ahhaa";
            StringBuilder sb = new StringBuilder();

            Console.WriteLine(string.Format("Input String: {0}", inputStr));

            for (int i = inputStr.Length - 1; i >= 0; i--)
            {
                sb.Append(inputStr[i]);
            }

            if (inputStr == sb.ToString())
            {
                Console.WriteLine("Is palindrome");
            }
            else
            {
                Console.WriteLine("Non palindrome");
            }

            Console.ReadLine();
        }
    }
}
