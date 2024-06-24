using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
     Calculate sum of even number from a int array
    https://www.fullstack.cafe/blog/c-sharp-coding-interview-questions
     */
    internal class Q19
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, 8, 9, 10, 11 };
            IEnumerable<int> evenNumArr = intArr.Where(x => x % 2 == 0);
            int totalEvenNum = evenNumArr.Sum();
        }
    }
}
