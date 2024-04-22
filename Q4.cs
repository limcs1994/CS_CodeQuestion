using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
   Reverse a string

   Example
    input: "Hello world"
    Output: "dlrow olleh"
  */

    internal class Q4
    {
        static void Main(string[] args)
        {
            string inputString = "AbcDefGhIJ";
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < inputString.Length; i++)
            {
                strBuilder.Append(inputString[inputString.Length -1 - i]);
            }

            Console.WriteLine("Reversed string: " + strBuilder.ToString());

            Console.ReadLine();
        }
    }
}
