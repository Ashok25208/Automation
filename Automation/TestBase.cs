using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoginTestModule;

namespace Automation
{
    [TestClass]
    public class TestBase
    {
        [TestMethod]
        public void Execution()
        {
            LoginTest Execute = new LoginTest();
            Execute.Login();
        }
    }
}
