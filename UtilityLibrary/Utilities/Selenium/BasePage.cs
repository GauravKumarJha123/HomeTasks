using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using UtilityClassLib.Report;

namespace UtilityClassLib.Utilities.Selenium
{
    public class BasePage 
    {
        public static ExtentReport ExtentObj = new ExtentReport();

        public static string browserName;

        [ThreadStatic]
        public static IWebDriver CurrentDriver;

        [SetUp]
        public void StartBrowser()
        {
            ExtentObj.ExtentStart();
            browserName = Navigation.GetValueAppConfig("browser");
            InitialiseBrowser(browserName);
        }

        [TearDown]
        public void EndBrowser()
        {
            ExtentObj.ExtentClose();
            CurrentDriver.Close();
        }

        public void InitialiseBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    CurrentDriver = new FirefoxDriver();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    CurrentDriver = new ChromeDriver();
                    break;
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    CurrentDriver = new EdgeDriver();
                    break;
            }
        }

        

    }
}
