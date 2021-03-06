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
    public class ProtaconTests
    {
        [Fact]
        public void TestMainPageTitleShouldBeCorrect()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");

            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options))
            {
                var protaconPage = new ProtaconPage(driver);
                protaconPage.Open();
            }
        }

        [Fact]
        public void TestNavigationToTietoturva()
        {

        }

        [Fact]
        public void TestUratarinatGoesToSingleUratarina()
        {

        }
    }
}
