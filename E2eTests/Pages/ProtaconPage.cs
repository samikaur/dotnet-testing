using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace E2eTests.Pages
{
    public class ProtaconPage
    {
        private readonly ChromeDriver _driver;

        public ProtaconPage(ChromeDriver driver)
        {
            _driver = driver;
        }

        public void Open(string url = "")
        {
            _driver.Navigate().GoToUrl(@"https://www.protacon.com/" + url);
        }

        public string GetTitle()
        {
            return _driver.Title;
        }

        public void NavigateToTietoturva()
        {
            _driver.FindElementById("menu-item-1728").Click();

            _driver.FindElementById("menu-item-10326").Click();
        }

        public void GoToUraTarina(string name)
        {
            var wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 5));

            wait.Until(drv => drv.FindElement(By.CssSelector(".main-content img.playercard")));

            // Hide accept cookie element
            _driver.FindElementById("cn-accept-cookie").Click();

            var links = _driver.FindElementByClassName("main-content").FindElements(By.TagName("a"));

            var link = links.First(m => m.GetAttribute("href").Contains(name));

            link.Click();
        }

        public string GetMainContent()
        {
            return _driver.FindElementByClassName("main-content").Text;
        }
    }
}
