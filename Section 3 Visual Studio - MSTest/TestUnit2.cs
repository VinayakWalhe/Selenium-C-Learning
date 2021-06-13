using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Selenium_with_C__Learning
{
    [TestClass]
    public class UnitTest2
    {
        [AssemblyInitialize]
        public static void BeforeAssembley(TestContext t)
        {
            Console.WriteLine("This before Before Assembley");
        }


        [AssemblyCleanup]
        public static void AfterAssembley(TestContext t)
        {
            Console.WriteLine("This before After Assembley");
        }

    }

    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void Testcase1()
        {
            Console.WriteLine("this is Test case 1");
        }

    }
}