using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;
using Microsoft.Extensions.Configuration;
using UtilityLibrary.Utilities.PageUtility;
using CSharpFramework.Utilities.Selenium;

namespace CSharpFramework.Utilities
{
    public class BaseTest 
    {
        public ExtentReports extent;
        public ExtentTest test;            
        public IWebDriver driver = DriverClass.CurrentDriver;

        //report File

        [OneTimeSetUp]
        public void Setup()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string reportPath = projectDirectory + "//index.html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            //extent.AttachReporter(htmlReporter);
            //extent.AddSystemInfo("Host Name", "Local host");
            //extent.AddSystemInfo("Environment", "QA");
            //extent.AddSystemInfo("UserName", "Gaurav");

        }

        //public IWebDriver driver;
        //public ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        [SetUp]
        public void StarTest()
        {
            DriverClass.StartBrowser();
            /// from Base Page            
            Setup();
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);// dynamic Test Name invoke
            
            
        }        

        public static JsonReader GetDataParser()
        {
            return new JsonReader();
        }

        [TearDown]
        public void EndTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;

            DateTime time = DateTime.Now;
            string fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";

            if(status == TestStatus.Failed)
            {
                test.Fail("Test Failed", captureScreenShot(DriverClass.CurrentDriver, fileName));
                test.Log(Status.Fail, "Test Failed with logTrace" + stackTrace);

            }else if(status == TestStatus.Passed)
            {
                test.Pass("Test Passed", captureScreenShot(DriverClass.CurrentDriver, fileName));
                test.Log(Status.Pass, "Test Passed with logTrace" + stackTrace);
            }
            extent.Flush();
            DriverClass.CurrentDriver.Quit();
            // from Base Page
        }

        public MediaEntityModelProvider captureScreenShot(IWebDriver driver , string screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            //save as file for local file
            var screenshot = ts.GetScreenshot().AsBase64EncodedString;

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();
        }

        //string userName, string Pass, string firstName, string lastName, string zipCode --> work upon this thing
        
    }
}
