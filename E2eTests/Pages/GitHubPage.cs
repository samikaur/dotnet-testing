using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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

        public void Search(string search)
        {
            _driver.FindElementById("your-repos-filter").SendKeys(search);

            var wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 5));

            wait.Until(drv => drv.FindElement(By.CssSelector("#org-repositories .v-align-top")));

        }

        public IList<string> GetRepositories()
        {
            var result = new List<string>();
            var repos = _driver.FindElementById("org-repositories").FindElements(By.TagName("li"));

            foreach (var webElement in repos)
            {
                var repo = webElement.FindElement(By.TagName("a")).Text;
                result.Add(repo);
            }

            return result;
        }
    }
}
