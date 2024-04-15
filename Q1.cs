using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
    //https://www.interviewkickstart.com/blog/interview-questions/intel-interview-questions
     Given a string s containing a set of words, transform it such that the words appear in the reverse order. Words in s are separated by one or more spaces. 
    
    Example
    Input: “I will do it.”
    Output: “it. do will I”

    Method:
    1. Flip whole string and the flip the text again
    2. Split string by "space" and reverse the array to string
    3. Loop string character one by one
     */

    internal class Q1
    {
        static void Main(string[] args)
        {
            string inputString = "Hi, how are you recently? ^-^";
            string tempString = string.Empty;
            string finalString = string.Empty;

            Console.WriteLine("Input string: " + inputString);

            for (int i = 0; i < inputString.Length; i++)
            {
                if ((i == inputString.Length - 1) && (tempString.Length > 0))
                {
                    tempString = tempString + inputString[i];
                    finalString = tempString + " " + finalString;
                }
                else if (inputString[i] == ' ')
                {
                    finalString = tempString + " " + finalString;
                    tempString = string.Empty;
                }
                else
                {
                    tempString = tempString + inputString[i];
                }
            }

            Console.WriteLine("Output string: " + finalString);

            Console.ReadLine();
        }
    }
}
