using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodeQuestion
{
    /*
    Count the appearance of each characters

    Example
    input: abba
    Output: a - 2, b - 2

    input: banana
    Output: a - 3, b - 1, n - 2
    */

    internal class Q06
    {
        static void Main(string[] args)
        {
            string inputStr = "Hey how are you doing Youngster";

            Dictionary<char, int> kvPairDict = new Dictionary<char, int>();

            for (int i = 0; i < inputStr.Length; i++)
            {
                if (kvPairDict.ContainsKey(char.ToLower(inputStr[i])))
                {
                    kvPairDict[char.ToLower(inputStr[i])]++;
                }
                else
                {
                    kvPairDict.Add(char.ToLower(inputStr[i]), 1);
                }
            }

            foreach (KeyValuePair<char, int> kvPair in kvPairDict)
            {
                Console.WriteLine(string.Format("Character {0} - {1}", kvPair.Key, kvPair.Value));
            }

            Console.WriteLine("");
            Console.WriteLine("===============================================");
            Console.WriteLine(" SORTED");

            var sortedKey = kvPairDict.Keys.OrderBy(x => x);

            foreach (char key in sortedKey)
            {
                Console.WriteLine(string.Format("Character {0} - {1}", key, kvPairDict.First(x => x.Key == key).Value.ToString()));
            }

            Console.ReadLine();
        }
    }
}
