using Framework.Models;
using Framework.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    class MainPage
    {
        IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        // Ввод неверного email при регистрации
        private const string accountButtonField = "/html/body/div[3]/div[2]/div/ul[2]/li[1]/span/span";
        private const string registrationButtonOnForm = "//*[@id=\"react-popup\"]/div/div[2]/div[5]/div[2]/a";
        private const string registrationEmailInput = "//*[@id=\"react-popup\"]/div/div[2]/div[2]/div[2]/input";
        private const string confirmRegistrationButton = "//*[@id=\"react-popup\"]/div/div[2]/div[3]";
        private const string outputErrorMessage = "//*[@id=\"react-popup\"]/div/div[2]/div[2]/div[3]/div[2]";

        // Подписка на скидки
        //*[@id"footer"]/div[1]/span
        private const string inputSubscribeName = "//*[@id=\"subscription-form\"]/span[1]/input";
        private const string inputSubscribeEmail = "//*[@id=\"footer\"]/div[1]/form/div/div/input";
        private const string subscribeButton = "//*[@id=\"footer\"]/div[1]/form/button";
        private const string outputSubscribeMessage = "//*[@id=\"footer\"]/div[1]/span";

        //Переход на стр спецпредложений
        private const string specialPageButton = "//*[@id=\"navbar\"]/li[4]/a";

        //Авторизация пользователя
        private const string authorizationEmailInput = "//*[@id=\"react-popup\"]/div/div[2]/div[2]/div[2]/input";


        private const string authorizationPasswordInput = "//*[@id=\"react-popup\"]/div/div[2]/div[3]/div[2]/input";
        private const string authorizationButton = "//*[@class=\"selen-pokdbn5820x\"]";
        private const string confirmAuthorizationSpan = "//*[@class=\"user_tools__link__outer\"]/span";

        // Поиск товаров через строку поиска
        private const string searhInput = "//*[@id=\"j-search\"]";
        private const string searhButton = "//*[@id=\"b-search\"]/form/fieldset/button";
        private const string firstSearchedProductName = "//*[@class=\"result__name\"]";

        private const string vkFooterIcon= "//*[@id=\"footer-inner\"]/div[3]/a[1]";



        // Ввод неверного email при регистрации
        [FindsBy(How = How.XPath, Using = accountButtonField)]
        public IWebElement AccountButton { get; set; }

        [FindsBy(How = How.XPath, Using = registrationButtonOnForm)]
        public IWebElement RegistrationButton { get; set; }

        [FindsBy(How = How.XPath, Using = registrationEmailInput)]
        public IWebElement RegistrationEmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = confirmRegistrationButton)]
        public IWebElement RegistrationConfirmButton { get; set; }

        [FindsBy(How = How.XPath, Using = outputErrorMessage)]
        public IWebElement ErrorMessage { get; set; }

    // Подписка на скидки
        [FindsBy(How = How.XPath, Using = inputSubscribeName)]
        public IWebElement SubscribeName { get; set; }

        [FindsBy(How = How.XPath, Using = inputSubscribeEmail)]
        public IWebElement SubscribeEmail { get; set; }

        [FindsBy(How = How.XPath, Using = subscribeButton)]
        public IWebElement SubscribeButton { get; set; }

        [FindsBy(How = How.XPath, Using = outputSubscribeMessage)]
        public IWebElement SubscribeMessage { get; set; }

    //Переход на стр спецпредложений
        [FindsBy(How = How.XPath, Using = specialPageButton)]
        public IWebElement SpecialPageButton { get; set; }

    //Авторизация пользователя
        [FindsBy(How = How.XPath, Using = authorizationEmailInput)]
        public IWebElement AuthorizationEmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = authorizationPasswordInput)]
        public IWebElement AuthorizationPasswordInput { get; set; }

        [FindsBy(How = How.XPath, Using = authorizationButton)]
        public IWebElement AuthorizationButton { get; set; }

        [FindsBy(How = How.XPath, Using = confirmAuthorizationSpan)]
        public IWebElement ConfirmAuthorizationSpan { get; set; }


        // Поиск товаров через строку поиска
        [FindsBy(How = How.XPath, Using = searhInput)]
        public IWebElement SearhInput { get; set; }

        [FindsBy(How = How.XPath, Using = searhButton)]
        public IWebElement SearhButton { get; set; }

        [FindsBy(How = How.XPath, Using = firstSearchedProductName)]
        public IWebElement FirstSearchedProductName { get; set; }

        [FindsBy(How = How.XPath, Using = vkFooterIcon)]
        public IWebElement VkFooterIcon { get; set; }

        private MainPage()
        {
        }

        public MainPage ClickOnAccountField()
        {
            AccountButton.Click();
            return new MainPage(driver);
        }

        public MainPage ClickToRegistrationButton()
        {
            RegistrationButton.Click();
            return new MainPage(driver);
        }
        public MainPage InputIncorrectEmail(User person)
        {
            RegistrationEmailInput.SendKeys(person.Email);
            return new MainPage(driver);
        }

        public MainPage ClickToRegistrationConfirmButton()
        {
            RegistrationConfirmButton.Click();
            return new MainPage(driver);
        }


        public MainPage InputSubscribeName(User person)
        {
            SubscribeName.SendKeys(person.Name);
            return new MainPage(driver);
        }
        public MainPage InputSubscribeEmail(User person)
        {
            SubscribeEmail.SendKeys(person.Email);
            return new MainPage(driver);
        }
        public MainPage ClickSubscribeButton()
        {
            SubscribeButton.Click();
            return new MainPage(driver);
        }


        public SpecialPage ClickOnSpecialPageButton()
        {
            SpecialPageButton.Click();
            return new SpecialPage(driver);
        }


        public MainPage InputAuthorizatePassAndEmail(User person)
        {
            AuthorizationEmailInput.SendKeys(person.Email);
            AuthorizationPasswordInput.SendKeys(person.Password);
            return new MainPage(driver);
        }

        public MainPage ClickAuthorizationButton()
        {
            AuthorizationButton.Click();
            return new MainPage(driver);
        }


        public MainPage SearchProductByName(string name)
        {
            SearhInput.SendKeys(name);
            SearhButton.Click();
            return new MainPage(driver);
        }


        public string ClickVkFooterIcon()
        {
            VkFooterIcon.Click();
            return driver.Url;
        }


    }
}
