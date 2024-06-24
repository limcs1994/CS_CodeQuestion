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
        //static void Main(string[] args)
        //{
        //    string inputStr = "ahhaa";
        //    StringBuilder sb = new StringBuilder();

        //    Console.WriteLine(string.Format("Input String: {0}", inputStr));

        //    for (int i = inputStr.Length - 1; i >= 0; i--)
        //    {
        //        sb.Append(inputStr[i]);
        //    }

        //    if (inputStr == sb.ToString())
        //    {
        //        Console.WriteLine("Is palindrome");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Non palindrome");
        //    }

        //    Console.ReadLine();
        //}

        static void Main(string[] args)
        {
            string aa = "alalalaa";
            char[] aaArr = aa.ToCharArray();

            for (int i = 0; i < aa.Length / 2; i++)
            {
                char tempChar;
                tempChar = aaArr[aa.Length - 1 - i];
                aaArr[aa.Length - 1 - i] = aaArr[i];
                aaArr[i] = tempChar;
            }

            Console.WriteLine(string.Join("", aaArr));

            if (string.Equals(aa, string.Join("", aaArr)))
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
