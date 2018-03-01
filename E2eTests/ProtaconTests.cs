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
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                var protaconPage = new ProtaconPage(driver);

                protaconPage.Open();

                Assert.Equal("Etusivu - Protacon", protaconPage.GetTitle());
            }
        }

        [Fact]
        public void TestNavigationToTietoturva()
        {            
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                var protaconPage = new ProtaconPage(driver);

                protaconPage.Open();

                protaconPage.NavigateToTietoturva();

                Assert.Equal("Tietoturva - Protacon", protaconPage.GetTitle());
            }
        }
        
        [Fact]
        public void TestUratarinatGoesToSingleUratarina()
        {            
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                var protaconPage = new ProtaconPage(driver);

                protaconPage.Open("uratarinat/");

                protaconPage.GoToUraTarina("pekka");

                Assert.Equal("#13 Pekka Savolainen - Protacon", protaconPage.GetTitle());

                Assert.Contains("Millainen on Peken normipäivä?", protaconPage.GetMainContent());
            }
        }
    }
}
