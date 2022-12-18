
using NUnit.Framework;
using OpenQA.Selenium;
using OrangeHRMPages.Pages;
using OrangeHRMPages.Pages.Admin;
using TechTalk.SpecFlow;
using UtilityLibrary.Selenium;
using UtilityLibrary.ExtensionMethods;

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
            adminPage.addUserPage.ClickonAddUserButton();
        }

        [When(@"I Enter User Details")]
        public void WhenIEnterUserDetails()
        {
            try
            {
                adminPage.addUserPage.SelectUserRole();
                adminPage.addUserPage.SelectStatus();
                adminPage.addUserPage.SelectEmployeeName();
                adminPage.addUserPage.EnterUserName();
                adminPage.addUserPage.EnterUserPassword();
                adminPage.addUserPage.EnterPasswordAgain();
                
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        [When(@"I Click on Save Button")]
        public void WhenIClickOnSaveButton()
        {
            Thread.Sleep(2000);
              adminPage.addUserPage.ClickOnSubmitButton();
            Thread.Sleep(6000);

        }

        [Then(@"User is Added")]
        public void ThenUserIsAdded()
        {
            Console.WriteLine(Driver.driver.Url.ToString());
            Assert.IsTrue(!Driver.driver.Url.Equals(Navigation.AddUserPage) , "User Not added");
        }

        #region Scneario 2

        IWebElement element;
        [When(@"I Fetch The records")]
        public void WhenIFetchTheRecords()
        {
            //Thread.Sleep(5000);
            element = adminPage.UserNamesByIdx(0);
        }

        [When(@"I Enter User Details in Search Fields")]
        public void WhenIEnterUserDetailsInSearchFields()
        {
            //Thread.Sleep(5000);

            adminPage.searchUserPage.EnterUserName(element.Text);
        }

        [When(@"I cllick on Search Button")]
        public void WhenICllickOnSearchButton()
        {
            //Thread.Sleep(5000);

            adminPage.ClickonSearchUserButton();
        }

        [Then(@"I Should Get the Users Value")]
        public void ThenIShouldGetTheUsersValue()
        {
            //Thread.Sleep(4000);
            element = adminPage.UserNamesByIdx(0);
            element.WeElementIsDisplayed();
        }

        


        #endregion

    }
}
