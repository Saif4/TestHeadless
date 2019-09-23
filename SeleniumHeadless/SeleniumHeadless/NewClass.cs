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
    public class NewClass
    {
        public const string windowsApplicationDriverUrl = "http://127.0.0.1:4723";
        public const string SYNKAppId = @"C:\Program Files (x86)\SYNKNET\Starternet.exe";
        public WindowsDriver<WindowsElement> session;
        public void Testt()
        {
            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", SYNKAppId);
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            options.AddAdditionalCapability("isHeadless", true);
           
            options.AddAdditionalCapability("avdArgs", "-no-window");
            session = new WindowsDriver<WindowsElement>(new Uri(windowsApplicationDriverUrl), options);

            Thread.Sleep(10000);
            session.FindElementByAccessibilityId("txtKundNr").SendKeys("123456");
            session.FindElementByName("Aktivera").Click();
        }
    }
}
