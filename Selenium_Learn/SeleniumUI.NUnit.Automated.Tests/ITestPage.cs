using TestBrowsers;

namespace SeleniumUI.NUnit.Automated.Tests
{
    public interface ITestPage
    {
        IBrowserDriver Browser { get; }

        string AppUrl { get; }

        string PageRoute { get; }
    }
}
