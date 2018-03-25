using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = string.Empty;
            expected = "Australia";
            string actual = (Division.ReturnStr(5));
            Assert.AreEqual(expected, actual);
        }
    }
}
