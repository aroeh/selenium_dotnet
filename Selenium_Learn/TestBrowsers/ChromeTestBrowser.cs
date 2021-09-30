using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace TestBrowsers
{
    public class ChromeTestBrowser : IBrowserDriver
    {
        private readonly IWebDriver webDriver;
        public IWebDriver Driver => webDriver;


        private readonly WebDriverWait wait;
        public WebDriverWait DriverWait => wait;


        public ChromeTestBrowser()
        {
            var options = new ChromeOptions();
            options.AddArgument("headless");
            webDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
    }
}
