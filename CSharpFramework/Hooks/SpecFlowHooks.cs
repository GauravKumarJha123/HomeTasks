using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UtilityLibrary.Utilities.PageUtility;
using CSharpFramework.Utilities.Selenium;

namespace CSharpFramework.Hooks
{
    //private BasePage basePage = new BasePage();

    [Binding]
    internal static class SpecFlowHooks
    {
        

        [Before]
        [Scope(Tag = "Chrome")]
        internal static void StartChromeDriver()
        {
            DriverClass.Init("Chrome");

        }

        [Before]
        [Scope(Tag = "Firefox")]
        internal static void StartFirefoxDriver()
        {
            DriverClass.Init("Firefox");

        }

        [After]
        internal static void StopWebDriver()
        {
            DriverClass.CurrentDriver.Quit();
        }
    }
}
