using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using TestBrowsers;

namespace SeleniumUI.NUnit.Automated.Tests
{
    public class CounterPage : ITestPage
    {
        public IBrowserDriver Browser { get; private set; }

        public string AppUrl { get; private set; }

        public string PageRoute => "counter";

        public CounterPage(IBrowserDriver testBrowser, string url)
        {
            Browser = testBrowser;
            AppUrl = url;
        }

        #region Page Elements

        public IWebElement PageTitle => Browser.Driver.FindElement(By.Id("page-title-counter"));
        public IWebElement CounterButton => Browser.Driver.FindElement(By.Id("btn-count"));

        #endregion Page Elements

        #region Page Actions

        public void Navigate()
        {
            Browser.Driver.Navigate().GoToUrl($"{AppUrl}{PageRoute}");
            Browser.DriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("page-title-counter")));
        }

        public void ClickCount() => CounterButton.Click();

        #endregion Page Actions
    }
}
