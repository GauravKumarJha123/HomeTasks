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

namespace CSharpFramework.Utilities.Selenium
{
    public class DriverClass
    {
        public static string? browserName;

        [ThreadStatic]
        public static IWebDriver CurrentDriver;
        public static void StartBrowser()
        {
            browserName = TestContext.Parameters["browserName"];
            if (browserName == null)
            {
                browserName = ConfigurationManager.AppSettings["browser"];
            }
            
                Init(browserName);

             
        }
        //public IWebDriver GetDriver()
        //{
        //    return CurrentDriver;
        //}
        public static void Init(string browserName)
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
