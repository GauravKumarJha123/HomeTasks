using TechTalk.SpecFlow;
using OrangeHRMPages.Pages;

namespace OrangeHRMTestProject.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps 
    {
        private LoginPage loginPage = new LoginPage();
        [Given(@"User is at the Login Page")]
        public void GivenUserIsAtTheHomePage()
        {
            loginPage.NavigateToLoginPage();
        }

        [When(@"User enter credentials '([^']*)' and '([^']*)'")]
        public void WhenUserEnterCredentialsAnd(string username, string userpass)
        {
            loginPage.EnterCredentials(username, userpass);
        }


        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            loginPage.ClickonLoginButton();
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            loginPage.LoginConfirmation();
        }
    }
}