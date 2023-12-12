using AventStack.ExtentReports.Reporter.Config;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System.Reflection;
using OpenQA.Selenium;

namespace Framework.Core.Reports
{
    public class ExtentManager
    {
        public static ExtentReports? _extentReports;

        public static ExtentReports GetInstance()
        {
            if (null == _extentReports) createInstance();
            return _extentReports!;
        }

        private static void createInstance()
        {
            string abc = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
            string WorkSpaceDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location.Replace("\\bin\\Debug\\net48", ""))!;
            ExtentSparkReporter htmlReporter = new ExtentSparkReporter(WorkSpaceDirectory + "\\ExecutionReports\\FinalReport.html");

            //------ Extent Spark Report Configuration ------//
            htmlReporter.Config.Theme = Theme.Dark;
            htmlReporter.Config.DocumentTitle = "Automation Report";
            htmlReporter.Config.ReportName = "Automation Report";

            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(htmlReporter);
        }

        public static string Capture(IWebDriver driver)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            return screenshot.AsBase64EncodedString;
        }
    }
}