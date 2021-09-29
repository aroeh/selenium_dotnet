using NUnit.Framework;
using TestDrivers;

namespace SeleniumUI.NUnit.Automated.Tests
{
    [TestFixture(typeof(EdgeTestDriver))]
    [TestFixture(typeof(ChromeTestDriver))]
    public class CounterPageTests<TWebDriver> where TWebDriver : ITestDriver, new()
    {
        private ITestDriver testRunner;
        private CounterPage page;
        private const string pageUrl = "https://localhost:5001/counter";

        [SetUp]
        public void Setup()
        {
            testRunner = new TWebDriver();
            page = new CounterPage(testRunner);

            page.Navigate();
        }

        [Test]
        public void Counter_Navigate_HasTitle()
        {
            //var pageTitle = testRunner.Driver.FindElement(By.Id("page-title-counter"));
            
            Assert.AreEqual("Counter", page.pageTitle.Text);
        }

        [Test]
        public void Counter_Navigate_HasCounterButton()
        {
            //var counterButton = testRunner.Driver.FindElement(By.Id("btn-count"));
            
            Assert.NotNull(page.counterButton);
            Assert.AreEqual("Click me", page.counterButton.Text);
        }

        [TearDown]
        public void EndTests()
        {
            testRunner.Driver.Quit();
            testRunner.Driver.Dispose();
        }
    }
}
