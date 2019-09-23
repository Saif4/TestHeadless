using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumHeadless
{
    public class SYNK
    {
        public const string windowsApplicationDriverUrl = "http://127.0.0.1:4723";
        public const string SYNKAppId = @"C:\Program Files (x86)\SYNKNET\Starternet.exe";
        public WindowsDriver<WindowsElement> session;
        public void TestavSynk()
        {
            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", SYNKAppId);
          //  options.AddAdditionalCapability("deviceName", "WindowsPC");
          //  options.AddAdditionalCapability("isHeadless", true);
           
            options.AddAdditionalCapability("avdArgs", "-no-window");
            session = new WindowsDriver<WindowsElement>(new Uri(windowsApplicationDriverUrl), options, TimeSpan.FromSeconds(5));

            var ValAvRedovisningsstället = session.FindElementByName("32701010");
            ValAvRedovisningsstället.Click();
            session.FindElementByName("OK").Click();
            
            var currentWindowHandle = session.CurrentWindowHandle;
            Thread.Sleep(TimeSpan.FromSeconds(5));
            var allWindowhandles = session.WindowHandles;
            session.SwitchTo().Window(allWindowhandles[0]);

            session.FindElementByAccessibilityId("txtKundNr").SendKeys("195306300368");
            session.FindElementByName("Aktivera").Click();
        }
    }
}
