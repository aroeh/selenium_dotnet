using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumUI.Automated.Tests.Drivers
{
    public interface ITestDriver
    {
        IWebDriver Driver { get; }
        WebDriverWait DriverWait { get; }
    }
}
