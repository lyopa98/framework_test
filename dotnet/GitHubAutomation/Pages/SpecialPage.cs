using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class SpecialPage
    {
        IWebDriver driver;
        public SpecialPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }


        private const string SpecialTextField = "content__header";
        private const string firstProductItem = "//*[@id=\"content\"]/div/div[3]/div[2]/ul/li[1]/dl/dd/a";//error

        //private const string firstProductItem ="//*[@id=\"content\"]/div/div[3]/div[2]/ul/li[1]/dl/dd/div/form/button";
        //*[@id="content"]/div/div[3]/div[2]/ul/li[1]/dl/dd/a

        [FindsBy(How = How.ClassName, Using = SpecialTextField)]
        public IWebElement SpecialHeader { get; set; }

        [FindsBy(How = How.XPath, Using = firstProductItem)]
        public IWebElement FirstProductItem { get; set; }

        public ProductPage ClickOnFirstProduct()
        {
            FirstProductItem.Click();
            return new ProductPage(driver);
        }


    }
}
