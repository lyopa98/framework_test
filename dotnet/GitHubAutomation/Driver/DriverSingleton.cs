using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Framework.Driver
{
    class DriverSingleton
    {
        static IWebDriver driver;

        private DriverSingleton() { }

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                switch (TestContext.Parameters.Get("browser"))
                {
                    case "Edge":
                        new DriverManager().SetUpDriver(new EdgeConfig());
                        driver = new EdgeDriver();
                        break;
                    default:
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        ChromeOptions chromeOptions = new ChromeOptions();
                        chromeOptions.AddArguments("--whitelist-ip *");
                        chromeOptions.AddArguments("--proxy-server='direct://'");
                        chromeOptions.AddArguments("--proxy-bypass-list=*");
                        chromeOptions.AddArguments("no-sandbox");
                        driver = new ChromeDriver(chromeOptions);
                        break;
                }
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(2);

                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void CloseDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
