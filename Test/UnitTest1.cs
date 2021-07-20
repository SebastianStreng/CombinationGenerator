using Microsoft.VisualStudio.TestTools.UnitTesting;
using CombinationGenerator;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Tokenpair> pairlist = new List<Tokenpair>();
            pairlist.Add(new Tokenpair("A", "B"));
            pairlist.Add(new Tokenpair("B", "C"));
            pairlist.Add(new Tokenpair("A", "C"));
            pairlist.Add(new Tokenpair("C", "D"));
            pairlist.Add(new Tokenpair("D", "B"));


        }



    }
}
