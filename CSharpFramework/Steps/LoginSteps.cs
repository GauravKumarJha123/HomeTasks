using CSharpFrameworkClassLib.Pages.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UtilityLibrary.Utilities.PageUtility;
using UtilityClassLib.Utilities.Selenium;
using OpenQA.Selenium;
using CSharpFramework.Utilities.Selenium;


namespace CSharpFramework.Steps
{
    [Binding]
    public class LoginSteps 
    {
        private LoginPage loginPage = new LoginPage();

        [Given(@"a user is on the base page")]
        public void GivenAUserIsOnTheBasePage()
        {
            loginPage.NavigateBaseUrl();
        }

        [When(@"I Enter Valid Credentials '([^']*)'")]
        public void WhenIEnterValidCredentials(string user)
        {
            loginPage.EnterUserName(user);
        }
        [When(@"I Enter Password '([^']*)'")]
        public void WhenIEnterPassword(string pass)
        {
            loginPage.UserPass(pass);
        }

        [When(@"I Click on Login Button")]
        public void WhenIClickOnLoginButton()
        { 
            loginPage.ClickLoginButton();
        }

        [Then(@"I Navigate to Inventory Page Url")]
        public void ThenINavigateToInventoryPageUrl()
        {
            loginPage.Verify();
            //var urlToValidate = Navigation.inventoryUrl.Contains(expectedUrl);
            //Assert.IsTrue(urlToValidate, " :: The actual page Url is different");
            //if (!urlToValidate) Console.WriteLine(" :: The actual page URL is " + urlToValidate);
        }



    }
}
