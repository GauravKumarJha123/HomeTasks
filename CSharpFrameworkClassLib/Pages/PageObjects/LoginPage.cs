using CSharpFramework.Utilities.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityClassLib.Utilities.Selenium;
using UtilityLibrary.Utilities.PageUtility;
using AventStack.ExtentReports;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class LoginPage : PageUtiltiy
    {
        #region Locators
        private By userName => By.XPath("//*[@id=\"user-name\"]");

        private By userPass => By.XPath("//*[@id=\"password\"]");

        private By loginBtn => By.XPath("//*[@id=\"login-button\"]");
        #endregion

        #region Events

        public void NavigateBaseUrl()
        {
            NavigatWrapper(Navigation.baseUrl);
            Maximize();
            Console.WriteLine(" :: The base URL is navigated to");
            extentReport.test = extentReport.report.CreateTest("Login Test").Info("Login Test Started");
            extentReport.test.Log(Status.Info, "Login Page is Launched");
        }
        public void EnterUserName(string user)
        {
            SendKeysWrapper(userName , user);
            extentReport.test.Log(Status.Info, "User Name " + user +" is Entered");

        }
        public void UserPass(string pass)
        {
            SendKeysWrapper(userPass, pass);
            extentReport.test.Log(Status.Info, "User Password " + pass + " is Entered");

        }

        public string GetUser()
        {
           return GetElement(userName).Text;
        }
        
        public void ClickLoginButton()
        {
            ClickWrapper(loginBtn);
            extentReport.test.Log(Status.Info, "Login Button is Clicked");

        }

        public bool VerifyNavigationToInventoryPage()
        {
            return (DriverClass.CurrentDriver.Url.Equals(Navigation.inventoryUrl)) ? true : false;
        }

        public void Verify()
        {
            if (VerifyNavigationToInventoryPage()) extentReport.test.Log(Status.Pass, "Login is SucessFull"); 
            else extentReport.test.Log(Status.Fail, "Login is Not Sucessfull");
        }
        //public InventoryPage NavigateToInventoryPage()
        //{
        //    ClickLoginButton();
        //    return new InventoryPage(CurrentDriver);
        //}
        #endregion
    }
}
