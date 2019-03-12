using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;

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
        [FindsBy(How = How.XPath, Using = "//div[@class='popover-content']")]
        [CacheLookup]
        public IWebElement PopOverDialog;
        [FindsBy(How = How.XPath, Using = "//div[@class='popover-content']//div//button[@id='btnYesLogout']")]
        [CacheLookup]
        public IWebElement PopOverYesLogout;
        [FindsBy(How = How.XPath, Using = "//div[@class='popover-content']//div//button[@id='btnNoLogout']")]
        [CacheLookup]
        public IWebElement PopOverNoLogout;
        [FindsBy(How = How.XPath, Using = "//span[@id='cart-count']")]
        [CacheLookup]
        public IWebElement CartCount;
        [FindsBy(How = How.LinkText, Using = "Logout")]
        [CacheLookup]
        public IWebElement LogoutOption;
        [FindsBy(How = How.XPath, Using = "rj ( Logged in as rjurbansc )")]
        [CacheLookup]
        public IWebElement LoggedUser;
        [FindsBy(How = How.XPath, Using = "//div[@id='profileModal']")]
        [CacheLookup]
        public IWebElement ProfileModal;
        [FindsBy(How = How.XPath, Using = "//div[@id='profileModal']//button[@class='btn'][contains(text(),'Cancel')]")]
        [CacheLookup]
        public IWebElement ProfileModalCancelOption;


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void LoginToApp()
        {
            UserName.SendKeys("Yuva_HM_DEV");
            PassWord.SendKeys("welcome1");
            LoginButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            if (ProfileModal.Displayed)
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                ProfileModalCancelOption.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            }
        }
    }
}
