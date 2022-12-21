
using NUnit.Framework;
using OpenQA.Selenium;
using OrangeHRMPages.Pages;
using OrangeHRMPages.Pages.Admin;
using TechTalk.SpecFlow;
using UtilityLibrary.Selenium;
using UtilityLibrary.ExtensionMethods;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OrangeHRMTestProject.StepDefinitions
{
    [Binding]
    public sealed class AdminSteps
    {
        private LoginPage _loginPage = new LoginPage();
        private AdminPage adminPage= new AdminPage();
        [Given(@"I am Logged in Sucessfully")]
        public void GivenIAmLoggedInSucessfully()
        {
            _loginPage.LoginConfirmation();
        }

        [When(@"I Click on Admin Tab")]
        public void WhenIClickOnAdminTab()
        {
            adminPage.ClickOnAdminTab();
        }

        [When(@"I Click on Add Button")]
        public void WhenIClickOnAddButton()
        {
            //correction
            adminPage.addUserPage.ClickonAddUserButton();
        }

        
        [When(@"I Select User Role")]
        public void WhenISelectUserRole()
        {
            try
            {
                adminPage.addUserPage.SelectUserRole();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        [When(@"I Select User Status")]
        public void WhenISelectUserStatus()
        {
            try
            {
                
                adminPage.addUserPage.SelectStatus();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        [When(@"I Select Employee Name")]
        public void WhenISelectEmployeeName()
        {
            try
            {
                
                adminPage.addUserPage.SelectEmployeeName();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        [When(@"I Select User Name")]
        public void WhenISelectUserName()
        {
            try
            {
                adminPage.addUserPage.EnterUserName();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        [When(@"I Select User Password")]
        public void WhenISelectUserPassword()
        {
            try
            {
                adminPage.addUserPage.EnterUserPassword();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        [When(@"I Enter Password Again")]
        public void WhenIEnterPasswordAgain()
        {
            try
            {
                adminPage.addUserPage.EnterPasswordAgain();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }




        [When(@"I Click on Save Button")]
        public void WhenIClickOnSaveButton()
        {
              adminPage.addUserPage.ClickOnSubmitButton();
        }

        [Then(@"User is Added")]
        public void ThenUserIsAdded()
        {
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Assert.IsTrue(!DriverManager.driver.Url.Equals(Navigation.AddUserPage) , "User Not added");
        }

        #region Scneario 2

        IWebElement element;
        [When(@"I Fetch The records")]
        public void WhenIFetchTheRecords()
        {
            element = adminPage.UserNamesByIdx(0);
        }

        [When(@"I Enter User Details in Search Fields")]
        public void WhenIEnterUserDetailsInSearchFields()
        {
            adminPage.searchUserPage.EnterUserName(element.Text);
        }

        [When(@"I cllick on Search Button")]
        public void WhenICllickOnSearchButton()
        {
            adminPage.ClickonSearchUserButton();
        }

        [Then(@"I Should Get the Users Value")]
        public void ThenIShouldGetTheUsersValue()
        {
            
            element = adminPage.UserNamesByIdx(0);
            element.WeElementIsDisplayed();
        }

        


        #endregion

    }
}
