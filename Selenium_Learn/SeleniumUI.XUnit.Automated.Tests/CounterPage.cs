using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using TestBrowsers;

namespace SeleniumUI.Automated.Tests
{
    public class CounterPage : IDisposable
    {
        private readonly IBrowserDriver testRunner;
        private const string pageUrl = "https://localhost:5001/counter";

        public CounterPage()
        {
            testRunner = new EdgeTestBrowser();
            //testRunner = new ChromeTestDriver();
        }

        #region Page Elements

        public IWebElement PageTitle => testRunner.Driver.FindElement(By.Id("page-title-counter"));
        public IWebElement CounterButton => testRunner.Driver.FindElement(By.Id("btn-count"));

        #endregion Page Elements

        #region Page Actions

        public void Navigate()
        {
            testRunner.Driver.Navigate().GoToUrl(pageUrl);
            testRunner.DriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("page-title-counter")));
        }

        public void ClickCount() => CounterButton.Click();

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
