using OpenQA.Selenium;
using System;

namespace EbayAutoFramework.Webdriver
{
    public class WebDriverContext
    {
        private static WebDriverContext _instance;

        private IWebDriver _webDriver = null;

        private WebDriverContext()
        {
        }

        public static WebDriverContext getInstance()
        {
            if (_instance == null)
            {
                _instance = new WebDriverContext();
            }

            return _instance;
        }
        public IWebDriver getWebDriver()
        {
            if (_webDriver == null)
            {
                createSession();
            }

            return _webDriver;
        }

        public void createSession()
        {
            if (_webDriver != null)
            {
                cleanUp();
            }

            String browser = "chrome";
            _webDriver = WebDriverFactory.createWebDriver(browser);
        }

        private void cleanUp()
        {
            if (_webDriver != null)
            {
                _webDriver.Close();
                _webDriver.Quit();

                // TODO: Investigate how to close orphaned chromedriver.exe.
                // This code works if the tests are run sequentially, but not in parallel.

                /*Process p;
                try
                {
                    String command = "";

                    if (Platform.CurrentPlatform.IsPlatformType (Platform))
                    {
                        command = "TASKKILL /F /IM chromedriver.exe";
                    }
                    else if (Platform.getCurrent().is (Platform.MAC))
                    {
                        command = "pkill -9 chromedriver";
                    }

                    p = Runtime.getRuntime().exec(command);
                    p.waitFor();
                }
                catch (IOException e)
                {
                    // TODO Auto-generated catch block
                    e.printStackTrace();
                }
                catch (InterruptedException e)
                {
                    e.printStackTrace();
                }

                _webDriver = null;*/
            }
        }
    }
}
