using Framework.Models;
using Framework.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    class ProductPage
    {
        IWebDriver driver;
        public ProductPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }


        private const string addToCartButton = "//*[@class=\"j-to_basket\"]/button";
        private const string addToFavoriteButton = "//*[@class=\"l-item_tools item-tools\"]/*[@class=\"item-tools__li cr-item-tools-putaside\"]/a";
        //*[@id="content"]/div[1]/div/div[2]/span[3]/a/span


        private const string addToCartButtonMessage = "//*[@class=\"item-buy\"]/*[@class=\"g-basketbtn\"]";

        private const string productReviewTab = "//*[@id=\"j-tabs-reviews\"]/div/div[@class=\"tabs__switcher\"]/span";      
        private const string productReviewShowFormButton = "//*[@id=\"j-tabs-reviews\"]/div[@class=\"tabs__content\"]/div/button[@class=\"g-button\"]";


        private const string inputNameField = "//*[@id=\"form-add-review\"]/*[@class=\"g-form__set\"]/label/*[@class=\"g-form__inputwrap\"]/input";
        private const string inputReviewField = "//*[@id=\"form-add-review\"]/*[@class=\"g-form__set\"]/label[2]/*[@class=\"g-form__inputwrap\"]/textarea";
        private const string inputReview5Star = "//*[@id=\"rev-star-5\"]";
        private const string addReviewButton = "//*[@id=\"form-add-review\"]/*[@class=\"g-form__tools g-form__set\"]/button";
        private const string addedReviewMessage = "//*[@class=\"reviews__thankyou\"]";

        private const string cartButton = "//*[@id=\"j-basket_counter\"]";


        [FindsBy(How = How.XPath, Using = addToCartButton)]
        public IWebElement AddToCartButton { get; set; }


        [FindsBy(How = How.XPath, Using = addToFavoriteButton)]
        public IWebElement AddToFavoriteButton { get; set; }

        [FindsBy(How = How.XPath, Using = addToCartButtonMessage)]
        public IWebElement ButtonMessage { get; set; }


        [FindsBy(How = How.XPath, Using = productReviewTab)]
        public IWebElement ProductReviewTab { get; set; }

        [FindsBy(How = How.XPath, Using = productReviewShowFormButton)]
        public IWebElement ProductReviewShowFormButton { get; set; }

        // Заполнение формы
        [FindsBy(How = How.XPath, Using = inputNameField)]
        public IWebElement InputNameField { get; set; }

        [FindsBy(How = How.XPath, Using = inputReviewField)]
        public IWebElement InputReviewField { get; set; }

        [FindsBy(How = How.XPath, Using = inputReview5Star)]
        public IWebElement InputReview5StarButton { get; set; }

        [FindsBy(How = How.XPath, Using = addReviewButton)]
        public IWebElement AddReviewButton { get; set; }

        [FindsBy(How = How.XPath, Using = addedReviewMessage)]
        public IWebElement AddedReviewMessage { get; set; }

        [FindsBy(How = How.XPath, Using = cartButton)]
        public IWebElement CartButton { get; set; }

        public ProductPage ClickAddToCartButton()
        {
            AddToCartButton.Click();
            return new ProductPage(driver);
        }

        public ProductPage ClickAddToFavoriteButton()
        {
            AddToFavoriteButton.Click();
            return new ProductPage(driver);
        }

        public ProductPage ClickProductReviewTab()
        {
            ProductReviewTab.Click();
            return new ProductPage(driver);
        }
        public ProductPage ClickProductReviewShowFormButton()
        {
            ProductReviewShowFormButton.Click();
            return new ProductPage(driver);
        }
        
        public ProductPage InputReviewToForm(User user, string review)
        {
            InputNameField.SendKeys(user.Name);
            InputReviewField.SendKeys(review);
            InputReview5StarButton.Click();
            return new ProductPage(driver);
        }

        public ProductPage ClickAddReviewButton()
        {
            AddReviewButton.Click();
            return new ProductPage(driver);
        }

        public CartPage ClickCartButton()
        {
            CartButton.Click();
            return new CartPage(driver);
        }
    }
}
