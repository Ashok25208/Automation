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

        
        public  LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void LoginToApp()
        {
            UserName.SendKeys("rjurbansc");
            PassWord.SendKeys("welcome1");
            LoginButton.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
    }
}
