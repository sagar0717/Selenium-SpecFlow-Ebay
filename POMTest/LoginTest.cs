using EbayAutoFramework;
using EbayAutoFramework.ObjectModels;
using EbayAutoFramework.Webdriver;
using NUnit.Framework;
using System.Threading;

namespace POMTest
{
    [TestFixture]
    public class LoginTest
    {
        [SetUp]
        public void navigateToEbay()
        {
            Driver.driver = WebDriverContext.getInstance().getWebDriver();
            Driver.driver.Manage().Window.Maximize();
            LoginPage lp = new LoginPage();
            lp.navigate();
        }
        [Test]
        public void navigateToSignIn()
        {
            LoginPage lp = new LoginPage();
            lp.signInLink.Click();
            Thread.Sleep(3000);
        }

        [TearDown]
        public void closeBrowser()
        {
            Driver.driver.Quit();
        }
    }
}
