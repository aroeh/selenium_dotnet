using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace TestDrivers
{
    public class EdgeTestDriver : ITestDriver
    {
        private readonly IWebDriver webDriver;
        public IWebDriver Driver => webDriver;

        private readonly WebDriverWait wait;
        public WebDriverWait DriverWait => wait;

        public EdgeTestDriver()
        {
            var options = new EdgeOptions
            {
                UseChromium = true
            };
            options.AddArgument("headless");
            webDriver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
    }
}
