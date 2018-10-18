using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace EbayAutoFramework.ObjectModels
{
    public class LoginPage : PageBase
    {
        public LoginPage()
        {
        }

        [FindsBy(How = How.XPath, Using = "//a[text()='Sign in']")]
        public IWebElement signInLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='userid']")]
        public IWebElement loginId { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='pass']")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='sgnBt']")]
        public IWebElement signInButton { get; set; }
    }
}
