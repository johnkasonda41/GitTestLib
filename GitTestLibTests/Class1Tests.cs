using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitTestLib;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GitTestLib.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        private readonly StringWriter sw = new StringWriter();
        private readonly String expected = "Hello World";
            
        [TestInitialize()]
        public void SetOut()
        {
            Console.SetOut(sw);
        }
        
        [TestMethod()]
        public void PrintTest()
        {
            Class1 printer = new Class1();
            printer.Print(expected);
            Assert.AreEqual(expected, sw.ToString().Trim());
        }

        [TestMethod()]
        public void PrintTest2()
        {
            Utility.Print(expected);
            Assert.AreEqual(expected, sw.ToString().Trim());
        }
    }
}