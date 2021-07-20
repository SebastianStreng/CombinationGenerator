using System;
using System.Collections.Generic;

namespace CombinationGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> alphabet = new List<string>()
            {
                    "A","B","C","D","E","F",
                    "G","H","I","J","K","L",
                    "M","N","O","P","Q","R",
                    "S","T","U","V","W","X",
                    "Y","Z"
            };

            combineValues(alphabet);
        }
        public static void combineValues(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    for (int k = 0; k < list.Count; k++)
                    {
                        var item = list[i];
                        var seconditem = list[j];
                        var thirditem = list[k];
                        Console.WriteLine(item + seconditem + thirditem);
                    }
                }
            }
        }
    }
}
