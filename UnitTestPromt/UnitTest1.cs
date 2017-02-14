using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleProject;
using System.Text.RegularExpressions;

namespace UnitTestPromt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPromt()
        {
            MyClass TestClass;
            //arrenge
            //string prompt(string name)
            string Test_str = "Mike";

            string Exp_res = "Hello, Mike";

            //Act
            MyClass testclass = new MyClass();

            string realresult = testclass.prompt(Test_str);
            StringAssert.StartsWith(realresult,"Hello");
             
        }
    }
}
