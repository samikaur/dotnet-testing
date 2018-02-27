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
    }
}
