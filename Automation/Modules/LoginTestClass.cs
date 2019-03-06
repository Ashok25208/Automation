using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using LoginPageObjects;


namespace LoginTestModule
{

    [TestFixture]
    public class LoginTest
    {
        [Test]
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = ConfigurationManager.AppSettings["QA"];
            var loginPage = new LoginPage(driver);
            loginPage.LoginToApp();

        }
    }
}
