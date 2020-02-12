using System;
using System.IO;
using Framework.Driver;

using Framework.Services;
using GitHubAutomation.Tests;
using GitHubAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System.Diagnostics;

namespace Framework.Tests
{
    class ShopTests : TestConfig
    {
        [Test]
        public void ErrorWhenRegistrationWithEmptyField()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://21vek.by/");
                string ErrorEmailString = "Неправильный формат электронной почты.";
                MainPage mainPage = new MainPage(Driver);

                var registationForm = mainPage.ClickOnAccountField().ClickToRegistrationButton();
                registationForm.InputIncorrectEmail(UserCreator.WithAllIncorrectProperties()).ClickToRegistrationConfirmButton();
                Assert.AreEqual(ErrorEmailString, registationForm.ErrorMessage.Text);

            });
          
        }

        //[Test]
        //public void DiscountSubscriptionTest()
        //{
        //    MakeScreenshotWhenFail(() =>
        //    {
        //        Driver.Navigate().GoToUrl("https://21vek.by/");
        //        string ErrorEmail = "Спасибо";
        //        MainPage mainPage = new MainPage(Driver);

        //        IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        //        js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

        //        var subscribeForm = mainPage.InputSubscribeEmail(UserCreator.WithAllProperties());
        //        subscribeForm.ClickSubscribeButton();
        //        Trace.WriteLine(subscribeForm.SubscribeMessage.Text);
        //        Assert.IsTrue(subscribeForm.SubscribeMessage.Text.Contains(ErrorEmail));

        //    });
        //}

        //[Test]
        //public void CheckSpecialProduct()
        //{
        //    MakeScreenshotWhenFail(() =>
        //    {
        //        Driver.Navigate().GoToUrl("https://21vek.by/");
        //        string SpacialPageString = "Скидки, суперцены";
        //        MainPage mainPage = new MainPage(Driver);

        //        SpecialPage specialPage = mainPage.ClickOnSpecialPageButton();
                

        //        Assert.AreEqual(SpacialPageString, specialPage.SpecialHeader.Text);

        //    });
        //}


        //[Test]
        //public void AddProductToCart()
        //{
        //    MakeScreenshotWhenFail(() =>
        //    {
        //        string AddMessageText = "В корзине";
        //        Driver.Navigate().GoToUrl("https://21vek.by/");
        //        MainPage mainPage = new MainPage(Driver);
        //        SpecialPage specialPage = mainPage.ClickOnSpecialPageButton();
        //        ProductPage productPage = specialPage.ClickOnFirstProduct()
        //                                             .ClickAddToCartButton();

        //        Assert.AreEqual(AddMessageText, productPage.ButtonMessage.Text);

        //    });
        //}

        //[Test]
        //public void AuthorizationUser()
        //{
        //    MakeScreenshotWhenFail(() =>
        //    {
        //        string AuthMessageText = "Моё";

        //        Driver.Navigate().GoToUrl("https://21vek.by/");

        //        MainPage mainPage = new MainPage(Driver);

        //        var authForm = mainPage.ClickOnAccountField();
        //        authForm.InputAuthorizatePassAndEmail(UserCreator.AuthProperties())
        //                .ClickAuthorizationButton();
        //        string value = authForm.ConfirmAuthorizationSpan.Text;

        //        Assert.AreEqual(AuthMessageText, value);

        //    });
        //}

        //[Test]
        //public void AddReview()
        //{
        //    MakeScreenshotWhenFail(() =>
        //    {
        //        Driver.Navigate().GoToUrl("https://21vek.by/");

        //        string goodAddedReviewMessage = "Спасибо за ваш отзыв! Он будет опубликован в ближайшее время после проверки модератором.";

        //        MainPage mainPage = new MainPage(Driver);
        //        var authForm = mainPage.ClickOnAccountField();
        //        authForm.InputAuthorizatePassAndEmail(UserCreator.AuthProperties())
        //                .ClickAuthorizationButton();

        //        SpecialPage specialPage = mainPage.ClickOnSpecialPageButton();
        //        ProductPage productPage = specialPage.ClickOnFirstProduct();
        //        productPage.ClickProductReviewTab()
        //                   .ClickProductReviewShowFormButton()
        //                   .InputReviewToForm(UserCreator.WithAllProperties(), "Тест системы автоматизации тестирования")
        //                   .ClickAddReviewButton();
        //        string value = productPage.AddedReviewMessage.Text;

        //        Assert.AreEqual(goodAddedReviewMessage, value);
        //    });
        //}

        //[Test]
        //public void SearchProductWithIncorrectSymbols()
        //{
        //    MakeScreenshotWhenFail(() =>
        //    {
        //        string goodSearhResult = "МЫШЬ";

        //        Driver.Navigate().GoToUrl("https://21vek.by/");
        //        MainPage mainPage = new MainPage(Driver);
        //        mainPage.SearchProductByName("!мышь(№");
        //        bool goodResult = mainPage.FirstSearchedProductName.Text.ToUpper().Contains(goodSearhResult);
               
        //        Assert.IsTrue(goodResult);

        //    });
        //}

        //[Test]
        //public void DeleteCartProduct()
        //{
        //    MakeScreenshotWhenFail(() =>
        //    {
        //        Driver.Navigate().GoToUrl("https://21vek.by/");
        //        string goodDeleteResult = "Ваша корзина пуста";
        //        MainPage mainPage = new MainPage(Driver);
        //        SpecialPage specialPage = mainPage.ClickOnSpecialPageButton();
        //        ProductPage productPage = specialPage.ClickOnFirstProduct()
        //                                             .ClickAddToCartButton();

        //        CartPage cartPage = productPage.ClickCartButton().ClickDeleteProductButton();
        //        Driver.Navigate().GoToUrl("https://21vek.by/order/");
        //        string goodResult = cartPage.ResultDataCount.GetAttribute("data-count");

        //        Assert.AreEqual("0", goodResult);

        //    });
        //}

        //[Test]
        //public void ClickRedirectVkIconFooter()
        //{
        //    MakeScreenshotWhenFail(() =>
        //    {

        //        Driver.Navigate().GoToUrl("https://21vek.by/");
        //        IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        //        js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        //        string redirectUrl = new MainPage(Driver).ClickVkFooterIcon();
        //        Assert.AreEqual("https://www.21vek.by/", redirectUrl);

        //    });
        //}

        //[Test]
        //public void AddProductToFavorite()
        //{
        //    MakeScreenshotWhenFail(() =>
        //    {
        //        string AddMessageText = "Удалить из избранного";
        //        Driver.Navigate().GoToUrl("https://21vek.by/");
        //        MainPage mainPage = new MainPage(Driver);
        //        SpecialPage specialPage = mainPage.ClickOnSpecialPageButton();
        //        ProductPage productPage = specialPage.ClickOnFirstProduct()
        //                                             .ClickAddToFavoriteButton();

        //        Assert.AreEqual(AddMessageText, productPage.AddToFavoriteButton.Text);

        //    });
        //}
    }
}
