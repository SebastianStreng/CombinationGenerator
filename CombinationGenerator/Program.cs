using System;
using System.Collections.Generic;

namespace CombinationGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<Tokenpair> pairlist = new List<Tokenpair>();
            //pairlist.Add(new Tokenpair("A", "B"));
            //pairlist.Add(new Tokenpair("B", "C"));
            //pairlist.Add(new Tokenpair("A", "C"));
            //pairlist.Add(new Tokenpair("C", "D"));
            //pairlist.Add(new Tokenpair("D", "B"));

            //combineValues(pairlist);

        }

        public static void combineValues(List<Tokenpair> list)
        {

            List<TokenPairTripples> tripplepairlist = new List<TokenPairTripples>();

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    for (int k = 0; k < list.Count; k++)
                    {
                        var item = list[i];
                        var seconditem = list[j];
                        var thirditem = list[k];

                        TokenPairTripples tripplepair = new TokenPairTripples(item, seconditem, thirditem);

                        tripplepairlist.Add(tripplepair);

                        for (int l = 0; l < tripplepairlist.Count; l++)
                        {
                            Console.WriteLine(tripplepairlist[l]);
                        }
                    }
                }
            }
        }

    }
}
