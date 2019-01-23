using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace LoginPageObjects
{
    [TestClass]
    public class LoginPage
    {
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//input[@id='txtUsername']")]
        [CacheLookup]
        public IWebElement UserName { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='txtPassword']")]
        [CacheLookup]
        public IWebElement PassWord { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='Button1']")]
        [CacheLookup]
        public IWebElement LoginButton { get; set; }

        [TestMethod]
        public void Login()
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

            UserName.SendKeys("rjurbansc");
            PassWord.SendKeys("welcome1");
            LoginButton.Submit();


        }
    }
}
