using OpenQA.Selenium;

namespace Framework.Core.Driver
{
    public interface IDriverWait
    {
        IWebElement FindElement(By elementLocator);
        IEnumerable<IWebElement> FindElements(By elementLocator);
    }
}