using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public static class UnitTest1
    {
        [TestMethod]
        public static void Can_Go_To_HomePage()
        {
            Pages.HomePage.Goto();



            Assert.IsTrue(Pages.HomePage.IsAt());

           
            
        }
    }
}
