using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ShoppingCartPageObjects
{
    [TestClass]
    public class ShoppingCartPage
    {
        public IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[3]/div[1]/button[1]")]
        [CacheLookup]
        public IWebElement ContinueOption;
        [FindsBy(How = How.XPath, Using = "//div[@id='shopCart1']//div[3]//div[2]//button[1]")]
        [CacheLookup]
        public IWebElement DeleteShoppingCartOption;



        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
