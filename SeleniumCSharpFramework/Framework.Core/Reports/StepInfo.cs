using AventStack.ExtentReports;
using Framework.Core.Driver;
using OpenQA.Selenium;
using System.Reflection;
using Xunit.Abstractions;

namespace Framework.Core.Reports
{
    public class StepInfo
    {
        private readonly ITestOutputHelper _output;
        public IWebDriver _driver { get; }

        public StepInfo(IWebDriver driver, ITestOutputHelper output)
        {
            _driver = driver;
            _output = output;
        }

        public void PrintInConsole(string Description)
        {
            Console.WriteLine(Description);
        }

        public void Step(string Description)
        {
            Pass(Description);
        }

        public void Info(string Description)
        {
            ExtentTestManager.GetTest().Info(Description);
            this.PrintInConsole(Description);
        }

        public void Pass(string Description)
        {
            ExtentTestManager.GetTest().Pass(Description);
            this.PrintInConsole(Description);
        }

        public void Fail(string Description)
        {
            var testMethod = GetType().GetMethod(_output.GetType().Name, BindingFlags.Instance | BindingFlags.NonPublic);
            string screenShotPath = ExtentManager.Capture(_driver);
            ExtentTestManager.GetTest().Fail(Description, MediaEntityBuilder.CreateScreenCaptureFromPath(screenShotPath).Build());
            this.PrintInConsole(Description);
        }

        public void Skip(string Description)
        {
            ExtentTestManager.GetTest().Skip(Description);
            this.PrintInConsole(Description);
        }
    }
}