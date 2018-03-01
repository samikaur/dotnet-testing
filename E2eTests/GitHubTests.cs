using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Reflection;
using System.Linq;
using E2eTests.Pages;

namespace E2eTests
{
    public class GitHubTests
    {
        [Fact]
        public void TestFindRepositorySearchReturnsCorrectRepositories()
        {
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                var gitHubPage = new GitHubPage(driver);

                gitHubPage.Open();
            }

        }
    }
}
