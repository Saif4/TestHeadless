using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    [TestClass]
    public class GoToWebSite
    {
        [TestMethod]
        public void VerifyTitle()
        {
            var options = new ChromeOptions();
           // options.AddArguments("headless");
            var browser = new ChromeDriver(options);

            browser.Navigate().GoToUrl("http://www.apple.com");
            var title = browser.Title;
            Console.WriteLine(title);
            browser.FindElementByLinkText("Mac").Click();
            var url = browser.Url;
            Assert.AreEqual(url, "https://www.apple.com/mac/");
            browser.Quit();
        }
 
    }
}
