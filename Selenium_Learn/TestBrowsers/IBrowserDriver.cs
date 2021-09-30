using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestBrowsers
{
    public interface IBrowserDriver
    {
        /// <summary>
        /// Interface for the web driver used to control browser actions and inputs
        /// </summary>
        IWebDriver Driver { get; }

        /// <summary>
        /// Wait helper to set wait timings on the web driver so actions have time to be registered and tested
        /// </summary>
        WebDriverWait DriverWait { get; }
    }
}
