using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Selenium_with_C__Learning
{
    [TestClass] 
    public class UnitTest1
    {
        [ClassInitialize] // This Method execute Before each method and class method should be static and method parameter should be TestContext
        public static void BeforeClass(TestContext t)
        {
            Console.WriteLine("Hello BeforeClass!!!!");
        }

        [ClassCleanup] //This Method execute Before each method and class method should be static 
        public static void AfterClass()
        {
            Console.WriteLine("Hello AfterClass!!!!");
        } 
      
        [TestInitialize] // This Method execute before each method
        public void TestInitialize()
        {
            Console.WriteLine("Hello TestInitialize!!!!");
        }
        
        [TestCleanup] //  This Method execute After each method
        public void TestCleanup()
        {
            Console.WriteLine("Hello TestCleanup!!!!");
        } 

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Hello Test!!!!");
        }

        // [TestMethod]
        // public void TestMethod2()
        // {
        //     Console.WriteLine("Hello Test!!!!");
        // }
        
        // [TestMethod]
        // public void TestMethod3()
        // {
        //     Console.WriteLine("Hello Test!!!!");
        // }
        //QA
    }

}