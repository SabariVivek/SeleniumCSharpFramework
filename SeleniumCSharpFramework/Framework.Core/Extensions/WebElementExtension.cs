using OpenQA.Selenium;

namespace Framework.Core.Extensions
{
    public static class WebElementExtension
    {
        public static void TypeText(this IWebElement element, string elementName, string elementValue)
        {
            element.SendKeys(elementValue);
            Console.WriteLine("Entered the value : \"" + elementValue + "\" in " + elementName + " field");
        }

        public static void Click(this IWebElement element, string elementName)
        {
            element.Click();
            Console.WriteLine("Clicked on " + elementName + " field");
        }

        public static void PageIdentifier(this IWebElement element, string pageName)
        {
            if (element.Displayed)
            {
                Console.WriteLine("User is in " + pageName + " name");
            }
            else
            {
                Console.WriteLine("User is not in " + pageName + " name");
            }
        }
    }
}