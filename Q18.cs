using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
      Different between ref and out
  */

    internal class Q18
    {
        static void Main(string[] args)
        {
            int abc = 0;
            Function1(ref abc);

            Function2(out int abcc);
            Console.WriteLine(abcc.ToString());
        }

        public static void Function1(ref int aaa)
        {

        }

        public static void Function2(out int bbb)
        {
            bbb = 0;
        }
    }
}
