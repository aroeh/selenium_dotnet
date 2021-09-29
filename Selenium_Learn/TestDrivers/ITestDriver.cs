using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestDrivers
{
    public interface ITestDriver
    {
        IWebDriver Driver { get; }
        WebDriverWait DriverWait { get; }
    }
}
