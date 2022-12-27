using UtilityClassLib.Utilities.Selenium;
using OpenQA.Selenium;
using UtilityLibrary.Utilities.PageUtility;
using AventStack.ExtentReports;
using UtilityClassLib.Report;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class LoginPage : PageUtiltiy
    {
        #region Locators
        private By UserName => GetXpathUsingID("user-name");
        private By UserPass => GetXpathUsingID("password");
        private By LoginBtn => GetXpathUsingID("login-button");
        #endregion

        #region Actions
        public void NavigateBaseUrl()
        {
            NavigatWrapper(Navigation.baseUrl);
            Maximize();
            Console.WriteLine(" :: The base URL is navigated to");
            ExtentObj.Test = ExtentObj.Report.CreateTest("Login Test").Info("Login Test Started");
            ExtentObj.Test.Log(Status.Info, "Login Page is Launched");
        }

        public void EnterUserName(string user)
        {
            SendKeysWrapper(UserName, user);
            ExtentObj.Test.Log(Status.Info, "User Name " + user + " is Entered");
        }

        public void UserPassword(string pass)
        {
            SendKeysWrapper(UserPass, pass);
            ExtentObj.Test.Log(Status.Info, "User Password " + pass + " is Entered");
        }

        public string GetUser()
        {
            return GetElement(UserName).Text;
        }

        public void ClickLoginButton()
        {
            ClickWrapper(LoginBtn);
            ExtentObj.Test.Log(Status.Info, "Login Button is Clicked");
        }

        public bool VerifyUrl()
        {
            return (BasePage.CurrentDriver.Url.Equals(Navigation.inventoryUrl)) ? true : false;
        }

        public void VerifyNavigationToInventoryPage()
        {
            DateTime time = DateTime.Now;
            String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
            if (VerifyUrl())
            {
                ExtentObj.Test.Log(Status.Pass, ExtentReport.CaptureScreenShot(BasePage.CurrentDriver, fileName));
            }
            else ExtentObj.Test.Log(Status.Fail, ExtentReport.CaptureScreenShot(BasePage.CurrentDriver, fileName));
        }

        #endregion
    }
}
