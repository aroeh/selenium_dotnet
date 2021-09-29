using Xunit;

namespace SeleniumUI.Automated.Tests
{
    public class CounterPageTests
    {
        private readonly CounterPage page;

        public CounterPageTests()
        {
            page = new CounterPage();
            page.Navigate();
        }

        [Fact]
        public void Counter_Navigate_HasTitle()
        {
            Assert.Equal("Counter", page.pageTitle.Text);
        }

        [Fact]
        public void Counter_Navigate_HasCounterButton()
        {
            Assert.NotNull(page.counterButton);
            Assert.Equal("Click me", page.counterButton.Text);
        }
    }
}
