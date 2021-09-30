using NUnit.Framework;
using TestBrowsers;

namespace SeleniumUI.NUnit.Automated.Tests
{
    [TestFixture(typeof(EdgeTestBrowser))]
    [TestFixture(typeof(ChromeTestBrowser))]
    public class CounterPageTests<TWebDriver> where TWebDriver : IBrowserDriver, new()
    {
        private IBrowserDriver browser;
        private CounterPage page;

        [SetUp]
        public void Setup()
        {
            browser = new TWebDriver();
            page = new CounterPage(browser, TestContext.Parameters["appUrl"]);

            page.Navigate();
        }

        [Test]
        public void Counter_Navigate_HasTitle()
        {
            Assert.AreEqual("Counter", page.PageTitle.Text);
        }

        [Test]
        public void Counter_Navigate_HasCounterButton()
        {
            Assert.NotNull(page.CounterButton);
            Assert.AreEqual("Click me", page.CounterButton.Text);
        }

        [TearDown]
        public void EndTests()
        {
            browser.Driver.Quit();
            browser.Driver.Dispose();
        }
    }
}
