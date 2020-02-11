using Framework.Models;
using Framework.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    class CartPage
    {

        IWebDriver driver;
        public CartPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        private const string deleteProductButton = "//*[@class=\"g-pseudo_href cr-from_basket j-from_basket\"]";
        private const string resultDataCount= "//*[@id=\"j-basket_counter\"]";

        [FindsBy(How = How.XPath, Using = deleteProductButton)]
        public IWebElement DeleteProductButton { get; set; }

        [FindsBy(How = How.XPath, Using = resultDataCount)]
        public IWebElement ResultDataCount { get; set; }

        public CartPage ClickDeleteProductButton()
        {
            DeleteProductButton.Click();
            return new CartPage(driver);
        }
    }

}
