using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;

namespace E2eTests.Pages
{
    public class ProtaconPage
    {
        private readonly ChromeDriver _driver;

        public ProtaconPage(ChromeDriver driver)
        {
            _driver = driver;
        }

        public void Open()
        {
            _driver.Navigate().GoToUrl(@"https://www.protacon.com/");
        }
    }
}
