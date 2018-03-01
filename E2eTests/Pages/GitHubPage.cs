using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;

namespace E2eTests.Pages
{
    public class GitHubPage
    {
        private readonly ChromeDriver _driver;

        public GitHubPage(ChromeDriver driver)
        {
            _driver = driver;
        }

        public void Open()
        {
            _driver.Navigate().GoToUrl(@"https://github.com/protacon/");
        }
    }
}
