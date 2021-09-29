using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using TestDrivers;

namespace SeleniumUI.NUnit.Automated.Tests
{
    public class CounterPage
    {
        private readonly ITestDriver driver;
        private const string pageUrl = "https://localhost:5001/counter";

        public CounterPage(ITestDriver testDriver)
        {
            driver = testDriver;
        }

        #region Page Elements

        public IWebElement pageTitle => driver.Driver.FindElement(By.Id("page-title-counter"));
        public IWebElement counterButton => driver.Driver.FindElement(By.Id("btn-count"));

        #endregion Page Elements

        #region Page Actions

        public void Navigate()
        {
            driver.Driver.Navigate().GoToUrl(pageUrl);
            driver.DriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("page-title-counter")));
        }

        public void ClickCount() => counterButton.Click();

        #endregion Page Actions
    }
}
