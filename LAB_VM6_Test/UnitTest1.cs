using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LAB_VM6_Test
{
    [TestClass]
    public class UnitTest1
    {
        double QuestFunction(double x) => Math.Pow(2, x) - 2 * x * x + 1;

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
