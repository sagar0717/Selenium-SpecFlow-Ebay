using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace EbayAutoFramework.Webdriver
{
    public class WebDriverFactory
    {
        public static IWebDriver createWebDriver(String browserType)

        {
            if (string.Equals(browserType, "chrome", StringComparison.OrdinalIgnoreCase))
            {
                return new ChromeDriver();
            }

            else if (string.Equals(browserType, "firefox", StringComparison.OrdinalIgnoreCase))
            {
                return new FirefoxDriver();
            }

            return null;
        }
    }
}
