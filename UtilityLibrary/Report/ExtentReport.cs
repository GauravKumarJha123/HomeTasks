using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;

namespace UtilityLibrary.Report
{
    public class ExtentReport
    {
        public static ExtentReports report { get; set; } = new ExtentReports();
        public static ExtentTest? Test;
        public static void ExtentStart()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Gaurav_Jha\source\repos\OrangeHRMPages\UtilityLibrary\Report\");
            report.AttachReporter(htmlReporter);
            report.AddSystemInfo("Host Name", "Local host");
            report.AddSystemInfo("Environment", "QA");
            report.AddSystemInfo("Username", "Gaurav Jha");
        }

        public static void ExtentClose()
        {
            report.Flush();
        }

        public static MediaEntityModelProvider CaptureScreenShot(IWebDriver driver, string screenShotName)
        {
            ITakesScreenshot takeScreenshot = (ITakesScreenshot)driver; //save as file for local file
            var screenshot = takeScreenshot.GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();
        }
    }
}
