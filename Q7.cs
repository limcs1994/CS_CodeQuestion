using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
    How to find out if the given two strings are anagrams

    Example
    input: silent , listen
    Output: ANAGRAMS

    input: banana , bahama
    Output: NON-ANAGRAMS
    */

    internal class Q7
    {
        static void Main(string[] args)
        {
            bool isAnagrams = true;
            string inputStr1 = "listen";
            string inputStr2 = "silent";
            Console.WriteLine(string.Format("Comparing \"{0}\" with \"{1}\"", inputStr1, inputStr2));

            char[] input1Arr = inputStr1.ToCharArray();
            char[] input2Arr = inputStr2.ToCharArray();

            if (input1Arr.Length != input2Arr.Length)
            {
                isAnagrams = false;
            }
            else
            {
                Array.Sort(input1Arr);
                Array.Sort(input2Arr);

                for (int i = 0; i < input1Arr.Length; i++)
                {
                    if (input1Arr[i] != input2Arr[i])
                    {
                        isAnagrams = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isAnagrams? "IS ANAGRAMS" : "NON-ANAGRAMS");
            Console.ReadLine();
        }
    }
}
