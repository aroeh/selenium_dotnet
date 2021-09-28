using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Chrome;

namespace SeleniumUI.Automated.Tests.Drivers
{
    public class ChromeTestDriver : ITestDriver
    {
        private readonly IWebDriver webDriver;
        public IWebDriver Driver => webDriver;


        private readonly WebDriverWait wait;
        public WebDriverWait DriverWait => wait;
        

        public ChromeTestDriver()
        {
            //webDriver = new ChromeDriver(@"C:\Users\arroe\source\repos\Tutorials\selenium_dotnet\drivers\chrome\chromedriver.exe");
        }
    }
}
