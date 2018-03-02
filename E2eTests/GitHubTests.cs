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
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");

            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options))
            {
                var gitHubPage = new GitHubPage(driver);

                gitHubPage.Open();

                gitHubPage.Search("docker");

                var result = gitHubPage.GetRepositories();

                Assert.Equal(3, result.Count());
                Assert.Equal("docker-dotnet-node-sdk", result.First());
            }

        }
    }
}
