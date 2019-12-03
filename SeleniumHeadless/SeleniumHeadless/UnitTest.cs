using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            var browser = new ChromeDriver(options);

            browser.Navigate().GoToUrl("http://www.apple.com");
            var t = browser.Title;
            Console.WriteLine(t);
            browser.FindElementByLinkText("Mac").Click();
            var url = browser.Url;
            Assert.AreEqual(url, "https://www.apple.com/mac/");
        }
 
    }
}
