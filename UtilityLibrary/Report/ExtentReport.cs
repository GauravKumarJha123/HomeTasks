using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System.Configuration;

namespace UtilityClassLib.Report
{

    public class ExtentReport
    {
        public ExtentReports Report { get; set; } = new ExtentReports();

        public ExtentTest? Test;
        public void ExtentStart()
        {
            var htmlReporter = new ExtentHtmlReporter(ConfigurationManager.AppSettings["extentReportFilePath"]);
            Report.AttachReporter(htmlReporter);
            Report.AddSystemInfo("Host Name", "Local host");
            Report.AddSystemInfo("Environment", "QA");
            Report.AddSystemInfo("Username", "Gaurav Jha");
        }

        public void ExtentClose()
        {
            Report.Flush();
        }

        public static MediaEntityModelProvider CaptureScreenShot(IWebDriver driver, string screenShotName)
        {
            ITakesScreenshot takeScreenshot = (ITakesScreenshot)driver; //save as file for local file
            var screenshot = takeScreenshot.GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();
        }

        //public void ExtentConfig()
        //{
        //    var status = TestContext.CurrentContext.Result.Outcome.Status;
        //    var stackTrace = TestContext.CurrentContext.Result.StackTrace;

        //    if (status == TestStatus.Failed)
        //    {
        //        Test.Log(Status.Fail, "test failed with logtrace" + stackTrace);
        //    }
        //    else if (status == TestStatus.Passed)
        //    {
        //        Test.Log(Status.Pass, "test Passed with logtrace" + stackTrace);
        //    }
        //}

    }
    //        string workingDirectory = Environment.CurrentDirectory;
    //        string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
    //        string reportPath = projectDirectory + "//index.html";
    //        var htmlReporter = new ExtentHtmlReporter(reportPath);
    //        report.AttachReporter(htmlReporter);
    
}
