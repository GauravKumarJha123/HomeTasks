﻿using OrangeHRMPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UtilityLibrary.Selenium;

namespace OrangeHRMTestProject.Hooks
{
    [Binding]
    internal static class SpecFlowHooks
    {
        [BeforeScenario]
        [Scope(Tag = "Chrome")]
        internal static void StartChromeDriver()
        {
            Driver.InitChrome();
        }

        [BeforeScenario("Admin")]
        [BeforeScenario("Admin01")]
        [BeforeScenario("Leave")]
        [BeforeScenario("TimeSheet")]
        [BeforeScenario("Recruitment")]
        [BeforeScenario("Recruitment01")]
        internal static void StartAdminPage()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.NavigateToLoginPage();
            loginPage.EnterCredentials("Admin", "admin123");
            loginPage.ClickonLoginButton();
            loginPage.LoginConfirmation();
        }

        [Before]
        [Scope(Tag = "Firefox")]
        internal static void StartFirefoxDriver()
        {
            Driver.InitFirefox();
        }

        [After]
        [Scope(Tag = "Chrome")]
        internal static void StopWebDriver()
        {
            Driver.driver.Quit();
        }
    }
}
