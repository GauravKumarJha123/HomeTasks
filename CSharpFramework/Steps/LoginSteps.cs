using CSharpFrameworkClassLib.Pages.PageObjects;
using TechTalk.SpecFlow;


namespace UtilityClassLib.Steps
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
            loginPage.UserPassword(pass);
        }

        [When(@"I Click on Login Button")]
        public void WhenIClickOnLoginButton()
        { 
            loginPage.ClickLoginButton();
        }

        [Then(@"I Navigate to Inventory Page Url")]
        public void ThenINavigateToInventoryPageUrl()
        {
            loginPage.VerifyNavigationToInventoryPage();
            //var urlToValidate = Navigation.inventoryUrl.Contains(expectedUrl);
            //Assert.IsTrue(urlToValidate, " :: The actual page Url is different");
            //if (!urlToValidate) Console.WriteLine(" :: The actual page URL is " + urlToValidate);
        }



    }
}
