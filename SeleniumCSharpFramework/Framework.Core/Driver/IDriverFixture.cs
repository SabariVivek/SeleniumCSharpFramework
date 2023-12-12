using OpenQA.Selenium;

namespace Framework.Core.Driver
{
    public interface IDriverFixture
    {
        IWebDriver Driver { get; }
    }
}