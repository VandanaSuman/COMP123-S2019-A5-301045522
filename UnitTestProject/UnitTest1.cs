using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using COMP123_S2019_A5_301045522;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.selectForm.ConnectedToDatabase());
           
        }
    }
}
