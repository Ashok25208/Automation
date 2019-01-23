using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace HomePageObjects
{
    [TestClass]
    public class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Home')]")]
        [CacheLookup]
        public IWebElement HomeOption;
        [FindsBy(How = How.XPath, Using = "//img[@src='/Redesign/Images/icon_catalog.png']")]
        [CacheLookup]
        public IWebElement CatalogOption;
        [FindsBy(How = How.XPath, Using = "//img[@src='/Redesign/Images/icon_orders.png']")]
        [CacheLookup]
        public IWebElement OrdersOption;

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
