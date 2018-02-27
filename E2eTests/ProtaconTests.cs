using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Reflection;
using System.Linq;

namespace E2eTests
{
    public class ProtaconTests
    {
        [Fact]
        public void TestMainPageTitleShouldBeCorrect()
        {            
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Navigate().GoToUrl(@"https://www.protacon.com/");

                Assert.Equal("Etusivu - Protacon", driver.Title);
            }
        }

        [Fact]
        public void TestNavigationToTietoturva()
        {            
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Navigate().GoToUrl(@"https://www.protacon.com/");

                driver.FindElementById("menu-item-1728").Click();

                driver.FindElementById("menu-item-10326").Click();

                Assert.Equal("Tietoturva - Protacon", driver.Title);
            }
        }
        
        [Fact]
        public void TestUratarinatGoesToSingleUratarina()
        {            
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Navigate().GoToUrl(@"https://www.protacon.com/uratarinat/");

                var links = driver.FindElementByClassName("main-content").FindElements(By.TagName("a"));

                var pekeLink = links.First(m => m.GetAttribute("href").Contains("pekka"));

                pekeLink.Click();

                Assert.Equal("#13 Pekka Savolainen - Protacon", driver.Title);
                Assert.True(driver.FindElementByClassName("main-content").Text.Contains("Millainen on Peken normipäivä?"));
            }
        }        
    }
}
