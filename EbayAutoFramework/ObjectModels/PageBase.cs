using SeleniumExtras.PageObjects;
using System;

namespace EbayAutoFramework.ObjectModels
{
    public class PageBase
    {

        public PageBase()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        public void navigate()
        {
            // navigateTo(config.BaseURL);
            Driver.driver.Navigate().GoToUrl(config.BaseURL);
        }

        public void navigateTo(String relativeUrl)
        {
            Driver.driver.Navigate().GoToUrl(config.BaseURL);
            //Wait.untilPageIsReady();
        }

        /*public void navigateBack()
        {
            _driver.navigate().back();
            //Wait.untilPageIsReady();
        }*/

        public String getCurrenturl()
        {
            return Driver.driver.Url;
        }

        /*public void navigateForward()
        {
            _driver.navigate().forward();
            Wait.untilPageIsReady();
        }*/

        public void navigateRefresh()
        {
            Driver.driver.Navigate().Refresh();
            //Wait.untilPageIsReady();
        }
    }
}
