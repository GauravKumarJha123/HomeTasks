using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace UtilityLibrary.Selenium
{
    public class DriverManager
    {
        public static WebDriverWait wait;
        public static ExtentReports report { get; set; } = new ExtentReports();
        public static ExtentTest? Test;

        [ThreadStatic]
        public static IWebDriver driver;

        public static void InitChrome()
        {
            ExtentStart();
            driver = new ChromeDriver();
        }

        public static void InitFirefox()
        {
            ExtentStart();
            driver = new FirefoxDriver();
        }

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
