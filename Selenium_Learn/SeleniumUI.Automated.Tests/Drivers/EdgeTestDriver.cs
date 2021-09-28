using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumUI.Automated.Tests.Drivers
{
    public class EdgeTestDriver : ITestDriver
    {
        private readonly IWebDriver webDriver;
        public IWebDriver Driver => webDriver;

        private readonly WebDriverWait wait;
        public WebDriverWait DriverWait => wait;

        public EdgeTestDriver()
        {
            var edgeOptions = new EdgeOptions
            {
                UseChromium = true
            };
            edgeOptions.AddArgument("headless");
            webDriver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), edgeOptions);
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
    }
}
