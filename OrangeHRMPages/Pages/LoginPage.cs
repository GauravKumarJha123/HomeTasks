using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UtilityLibrary.PageUtility;
using static UtilityLibrary.Selenium.Navigation;
//using static UtilityLibrary.Selenium.BasePage;

namespace OrangeHRMPages.Pages
{
    public class LoginPage : BasePage
    {
        private By UserName => By.XPath("//input[@placeholder='Username']");

        private By UserPassword => By.XPath("//input[@placeholder='Password']");

        private By LoginButton => By.XPath("//button[@type='submit']");
        public void NavigateToLoginPage()
        {
            NavigatWrapper(BasePageUrl);
        }
        public void LoginConfirmation()
        {
            try
            {
                //BasePage.Driver
                if (!driver.Url.Equals(DashboardUrl))
                {
                    throw new Exception("Login Not Sucessfull");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public void EnterCredentials(string username, string password)
        {
            SendKeysWrapper(UserName, username);
            SendKeysWrapper(UserPassword, password);
        }

        public void ClickonLoginButton()
        {
            ClickWrapper(LoginButton);
        }

        public void EnterCredentialsUsingTable(Table table, IEnumerable<dynamic> credentials)
        {
            foreach (var users in credentials)
            {
                SendKeysWrapper(UserName, users.Username);
                SendKeysWrapper(UserPassword, users.Password);
                ClickWrapper(LoginButton);
                ClearWrapper(UserName);
                ClearWrapper(UserPassword);
            }
        }
    }
}
