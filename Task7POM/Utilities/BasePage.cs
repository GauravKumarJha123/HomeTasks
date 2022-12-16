using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Task7POM.Utilities
{
    public class BasePage
    {
        public static string browserName;

        [ThreadStatic]
        public static IWebDriver CurrentDriver;

        public void StartBrowser()
        {
            browserName = "Chrome";
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

        public void EndBrowser()
        {
            CurrentDriver.Close();
        }

    }
}
