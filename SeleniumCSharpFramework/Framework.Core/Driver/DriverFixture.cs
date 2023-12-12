using Framework.Core.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace Framework.Core.Driver
{
    public class DriverFixture : IDriverFixture, IDisposable
    {
        private readonly TestSettings _testSettings;

        public IWebDriver Driver { get; }

        public DriverFixture(TestSettings testSettings)
        {
            _testSettings = testSettings;
            Driver = GetWebDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_testSettings.ApplicationUrl);
        }

        public IWebDriver GetWebDriver()
        {
            return _testSettings.BrowserType switch
            {
                BrowserType.CHROME => new ChromeDriver(),
                BrowserType.EDGE => new EdgeDriver(),
                BrowserType.FIREFOX => new FirefoxDriver(),
                _ => new ChromeDriver()
            };
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }

    public enum BrowserType
    {
        CHROME,
        EDGE,
        FIREFOX
    }
}