using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Chrome;

namespace SeleniumHeadless
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Aftonbladet()
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            options.AddArguments("disable-gpu");
            var browser = new ChromeDriver(options);

            
            browser.Navigate().GoToUrl("http://www.aftonbladet.se");
            //  browser.FindElementByName("Google").SendKeys("Aftonbladet");
            // browser.FindElementByName("Sök åå Google").Click();
            var t = browser.Title;
            
        }
        [TestMethod]
        public void headless()
        {

            NewClass newClass = new NewClass();
            newClass.Testt();
        }
    }
}
