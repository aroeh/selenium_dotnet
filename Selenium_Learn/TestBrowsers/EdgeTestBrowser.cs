using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace TestBrowsers
{
    public class EdgeTestBrowser : IBrowserDriver
    {
        private readonly IWebDriver webDriver;
        /// <summary>
        /// Interface for the web driver used to control browser actions and inputs
        /// </summary>
        public IWebDriver Driver => webDriver;

        private readonly WebDriverWait wait;
        /// <summary>
        /// Wait helper to set wait timings on the web driver so actions have time to be registered and tested
        /// </summary>
        public WebDriverWait DriverWait => wait;

        public EdgeTestBrowser()
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
