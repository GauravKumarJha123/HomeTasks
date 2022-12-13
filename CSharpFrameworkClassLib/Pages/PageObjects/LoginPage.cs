using CSharpFramework.Utilities.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.Utilities.PageUtility;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class LoginPage : BasePage
    {
        IWebDriver driver = DriverClass.CurrentDriver;

        public LoginPage()
        {


        }
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Locators
        private By userName => By.XPath("//*[@id=\"user-name\"]");

        private By userPass => By.XPath("//*[@id=\"password\"]");

        private By loginBtn => By.XPath("//*[@id=\"login-button\"]");
        #endregion

             

        #region Events
        public void EnterUserName(string user)
        {
            SendKeysWrapper(userName , user);
        }
        public void UserPass(string pass)
        {
            SendKeysWrapper(userPass, pass);

        }

        public string GetUser()
        {
           return GetElement(userName).Text;
        }
        
        public void ClickLoginButton()
        {
            ClickWrapper(loginBtn);

        }
        public InventoryPage NavigateToInventoryPage()
        {
            ClickLoginButton();
            return new InventoryPage(driver);
        }
        #endregion
    }
}
