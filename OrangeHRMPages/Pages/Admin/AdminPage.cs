using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.ExtensionMethods;
using static UtilityLibrary.Selenium.DriverManager;


namespace OrangeHRMPages.Pages.Admin
{
    public class AdminPage : BasePage
    {
        public AddUserPage addUserPage { get; set; } = new AddUserPage();

        public SearchUserPage searchUserPage { get; set; } = new SearchUserPage();
        private By AdminTab => By.XPath("//span[text()='Admin']");

        //a[@class='oxd-main-menu-item active']

        public void ClickOnAdminTab()
        {
            AdminTab.ClickExtension();
            Test.Log(Status.Info, "Selected Status of User");

        }



    }
}
