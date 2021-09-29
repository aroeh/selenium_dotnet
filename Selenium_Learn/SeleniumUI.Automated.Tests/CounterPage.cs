using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using TestDrivers;

namespace SeleniumUI.Automated.Tests
{
    public class CounterPage : IDisposable
    {
        private readonly ITestDriver testRunner;
        private const string pageUrl = "https://localhost:5001/counter";

        public CounterPage()
        {
            testRunner = new EdgeTestDriver();
            //testRunner = new ChromeTestDriver();
        }

        #region Page Elements

        public IWebElement pageTitle => testRunner.Driver.FindElement(By.Id("page-title-counter"));
        public IWebElement counterButton => testRunner.Driver.FindElement(By.Id("btn-count"));

        #endregion Page Elements

        #region Page Actions

        public void Navigate()
        {
            testRunner.Driver.Navigate().GoToUrl(pageUrl);
            testRunner.DriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("page-title-counter")));
        }

        public void ClickCount() => counterButton.Click();

        #endregion Page Actions

        #region IDisposable Members

        public void Dispose()
        {
            testRunner.Driver.Quit();
            testRunner.Driver.Dispose();
        }

        #endregion IDisposable Members
    }
}
