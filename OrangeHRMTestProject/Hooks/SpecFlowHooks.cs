using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OrangeHRMPages.Pages;
using TechTalk.SpecFlow;
using UtilityLibrary.Selenium;
using Serilog;
using AventStack.ExtentReports.Gherkin.Model;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Security.AccessControl;
using LivingDoc.Dtos;
using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using static UtilityLibrary.Selenium.DriverManager;

namespace OrangeHRMTestProject.Hooks
{
    [Binding]
    public class SpecFlowHooks
    {
        [BeforeScenario]
        [Scope(Tag = "Chrome")]
        internal static void StartChromeDriver()
        {
            DriverManager.InitChrome();
            Test = report.CreateTest(ScenarioContext.Current.ScenarioInfo.Title).Info("Test Started");
        }

        [BeforeScenario("Admin")]
        [BeforeScenario("Admin01")]
        [BeforeScenario("Leave")]
        [BeforeScenario("TimeSheet")]
        [BeforeScenario("Recruitment")]
        [BeforeScenario("Recruitment01")]
        public static void StartLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.NavigateToLoginPage();
            loginPage.EnterCredentials("Admin", "admin123");
            loginPage.ClickonLoginButton();
            loginPage.LoginConfirmation();
        }

        [BeforeScenario]
        [Scope(Tag = "Firefox")]
        internal static void StartFirefoxDriver()
        {
            DriverManager.InitFirefox();
        }

        [After]
        [Scope(Tag = "Chrome")]
        [Scope(Tag = "Firefox")]
        internal static void StopWebDriver()
        {
            ExtentClose();
            DriverManager.driver.Quit();
        }
    }
}
