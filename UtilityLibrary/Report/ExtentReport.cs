using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CSharpFramework.Utilities.Selenium;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityClassLib.Utilities.Selenium;

namespace UtilityClassLib.Report
{

    public class ExtentReport
    {
        public ExtentReports report = new ExtentReports();
        public ExtentTest test;
        
        public void ExtentStart()
        {
            var htmlReporter = new ExtentHtmlReporter(ConfigurationManager.AppSettings["extentReportFilePath"]);
            report.AttachReporter(htmlReporter);
            report.AddSystemInfo("Host Name", "Local host");
            report.AddSystemInfo("Environment", "QA");
            report.AddSystemInfo("Username", "Gaurav Jha");
        }
        
        public void ExtentClose()
        {
            //var status = TestContext.CurrentContext.Result.Outcome.Status;
            //var stackTrace = TestContext.CurrentContext.Result.StackTrace;
            //DateTime time = DateTime.Now;
            //String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";

            //if (status == TestStatus.Failed)
            //{
            //    test.Fail("Test Failed", captureScreenShot(DriverClass.CurrentDriver, fileName));
            //    test.Log(Status.Fail, "test failed with logtrace" + stackTrace);
            //}
            //else if (status == TestStatus.Passed)
            //{
            //    test.Pass("Test Passed", captureScreenShot(DriverClass.CurrentDriver, fileName));
            //    test.Log(Status.Pass, "test Passed with logtrace" + stackTrace);
            //}

            report.Flush();
        }

        //public void ExtentConfig()
        //{
        //    var status = TestContext.CurrentContext.Result.Outcome.Status;
        //    var stackTrace = TestContext.CurrentContext.Result.StackTrace;
        //    DateTime time = DateTime.Now;
        //    String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";

        //    if (status == TestStatus.Failed)
        //    {
        //        test.Fail("Test Failed", captureScreenShot(DriverClass.CurrentDriver, fileName));
        //        test.Log(Status.Fail, "test failed with logtrace" + stackTrace);
        //    }
        //    else if (status == TestStatus.Passed)
        //    {
        //        test.Pass("Test Passed", captureScreenShot(DriverClass.CurrentDriver, fileName));
        //        test.Log(Status.Pass, "test Passed with logtrace" + stackTrace);
        //    }
        //}

        //public void Conig()
        //{
        //    var status = TestContext.CurrentContext.Result.Outcome.Status;
        //    var stackTrace = TestContext.CurrentContext.Result.StackTrace;
        //    DateTime time = DateTime.Now;
        //    String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";

        //    if (status == TestStatus.Failed)
        //    {
        //        test.Fail("Test Failed", captureScreenShot(DriverClass.CurrentDriver, fileName));
        //        test.Log(Status.Fail, "test failed with logtrace" + stackTrace);
        //    }
        //    else if (status == TestStatus.Passed)
        //    {
        //        test.Pass("Test Passed", captureScreenShot(DriverClass.CurrentDriver, fileName));
        //        test.Log(Status.Pass, "test Passed with logtrace" + stackTrace);
        //    }
        //}
        public static MediaEntityModelProvider captureScreenShot(IWebDriver driver, string screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            //save as file for local file
            var screenshot = ts.GetScreenshot().AsBase64EncodedString;

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();
        }
    }

    //public class ExtentReport
    //{
    //    public  ExtentReports report = null;
    //    public ExtentTest test = null;

    //    public void Extentstart()
    //    {
    //        report = new ExtentReports();
    //        string workingDirectory = Environment.CurrentDirectory;
    //        string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
    //        string reportPath = projectDirectory + "//index.html";
    //        var htmlReporter = new ExtentHtmlReporter(reportPath);
    //        report.AttachReporter(htmlReporter);
    //    }

    //    public void ExtentClose()
    //    {
    //        report.Flush();
    //    }

    //}
}
