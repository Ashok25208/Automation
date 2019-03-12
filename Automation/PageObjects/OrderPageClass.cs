using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using HomePageObjects;

namespace OrdersPageObjects
{
    [TestClass]
    public class OrdersPage
    {
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//a[@href='/Redesign/'][contains(text(),'Orders')]")]
        [CacheLookup]
        public IWebElement OrdersTab;
        [FindsBy(How = How.XPath, Using = "//img[@src='/Redesign/Images/icon_catalog.png']")]
        [CacheLookup]
        public IWebElement CatalogHome;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Home')]")]
        [CacheLookup]
        public IWebElement HomePageOption;
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/header[1]/div[3]/ul[1]/li[3]/ul[1]/li[2]/a[1]")]
        [CacheLookup]
        public IWebElement StagedOrderOption;
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/header[1]/div[3]/ul[1]/li[3]/ul[1]/li[1]/a[1]")]
        [CacheLookup]
        public IWebElement CatalogOrderOption;
        [FindsBy(How = How.XPath, Using = "//input[@id='itemCode']")]
        [CacheLookup]
        public IWebElement ItemCodeField;
        [FindsBy(How = How.XPath, Using = "//input[@id='description']")]
        [CacheLookup]
        public IWebElement DescriptionField;
        [FindsBy(How = How.XPath, Using = "//button[@id='btnSearch']")]
        [CacheLookup]
        public IWebElement SearchOption;
        [FindsBy(How = How.XPath, Using = "//button[@id='btnSearchClear']")]
        [CacheLookup]
        public IWebElement ClearSearchOption;
        [FindsBy(How = How.XPath, Using = "")]
        [CacheLookup]
        public IWebElement OrderQuantity;
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Add to Cart')]")]
        [CacheLookup]
        public IWebElement AddCatalogItemToCart;
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[8]/div[2]/button[1]")]
        [CacheLookup]
        public IWebElement SaveOptioninMOE;
      

        public OrdersPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            
        }

        public OrdersPage()
        {
        }
        
        public void CatalogOrderAddToCart()
        {
            Actions builder = new Actions(driver);
            IAction MouseOver = builder
                .MoveToElement(OrdersTab)
                .MoveToElement(CatalogOrderOption).Click()
                .Build();
            MouseOver.Perform();
            ItemCodeField.SendKeys("AFOUND 22000 WOVEN SIZE GREEN S");
            DescriptionField.SendKeys("AFOUND 22000 WOVEN SIZE GREEN S");
            SearchOption.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            OrderQuantity.SendKeys("500");
            AddCatalogItemToCart.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            SaveOptioninMOE.Click();

            


        }
    }
    public class Action : IAction 
    {
        public void Perform()
        {
            throw new NotImplementedException();
        }
    }
}
