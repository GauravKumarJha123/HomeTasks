//using AventStack.ExtentReports.Model;
//using AventStack.ExtentReports;
//using ICSharpCode.SharpZipLib.Zip;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Firefox;
//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UtilityClassLib.Report;
//using WebDriverManager.DriverConfigs.Impl;
//using NUnit.Framework;
//using AventStack.ExtentReports.Reporter;
using System;
using System.Configuration;
using System.IO;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using UtilityClassLib.Report;

namespace CSharpFramework.Utilities.Selenium
{
    public class DriverClass 
    {

        public static ExtentReport extentReport = new ExtentReport();
        public static string browserName;

        [ThreadStatic]
        public static IWebDriver CurrentDriver;
        [SetUp]
        public void StartBrowser()
        {
            
            extentReport.ExtentStart();
            browserName = ConfigurationManager.AppSettings["browser"];
            if (browserName == "Chrome")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                CurrentDriver = new ChromeDriver();

            }
            else
            {
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                CurrentDriver = new FirefoxDriver();
            }

        }
        [TearDown]
        public void EndBrowser()
        {
           
            extentReport.ExtentClose();
            CurrentDriver.Close();
        }




        //public IWebDriver GetDriver()
        //{
        //    return CurrentDriver;
        //}
        //public static void Init(string browserName)
        //{
        //    switch (browserName)
        //    {
        //        case "Firefox":
        //            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
        //            CurrentDriver = new FirefoxDriver();
        //            break;

        //        case "Chrome":
        //            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
        //            CurrentDriver = new ChromeDriver();
        //            break;
        //        case "Edge":
        //            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
        //            CurrentDriver = new EdgeDriver();
        //            break;
        //    }
        //}
    }
}
