﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework
{
    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "menu-item-25")]
        public IWebElement Introduction { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-106")]
        public IWebElement Selectors { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-25")]
        public IWebElement SpecialElements { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-25")]
        public IWebElement TestCases { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-25")]
        public IWebElement TestScenarios { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-25")]
        public IWebElement About { get; set; }
    }
}

