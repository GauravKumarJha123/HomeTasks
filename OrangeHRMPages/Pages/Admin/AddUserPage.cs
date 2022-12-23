using AngleSharp.Html.Dom;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Runtime.CompilerServices;
using UtilityLibrary.ExtensionMethods;
using static OrangeHRMPages.Support.Misc;
using static UtilityLibrary.Selenium.DriverManager;

namespace OrangeHRMPages.Pages.Admin
{
    public class AddUserPage : BasePage
    {
        private By UserRoleXpath => By.XPath("(//div[contains(text(),'-- Select --')])[1]");

        private By StatusXpath => By.XPath("(//div[contains(text(),'-- Select --')])");
        
        private By EmployeeNameXpath => By.XPath("//input[@placeholder='Type for hints...']");

        private By UserNameXpath => By.XPath("(//input[@class='oxd-input oxd-input--active'])[2]");

        private By PasswordFields => By.XPath("//input[@type='password']");

        private By SubmitButton => By.XPath("//button[@type='submit']");
        private By listBox => By.XPath("//div[@role='listbox']");
        //private IEnumerable<IWebElement> webElements;

        private readonly IWebDriver _driver = driver;
        public void SelectUserRole()
        {
            IWebElement el = UserRoleXpath.FindElementExtension();
            //el.WeElementIsEnabled();
            el.ClickWebElement();
            listBox.DropdwonByTextExtension(AdminUser);
            Test.Log(Status.Info, "Selected " + AdminUser + " as User");
        }

        public void SelectStatus()
        {
            IWebElement el = StatusXpath.FindElementExtension();
            //el.WeElementIsEnabled();
            el.ClickWebElement();
            listBox.DropdwonByTextExtension(StatusEnabled);
            Test.Log(Status.Info, "Selected " + StatusEnabled +  " for User");

        }

        public void SelectEmployeeName()
        {
            EmployeeNameXpath.SendKeysExtension(EmployeeName);
            Thread.Sleep(2000);
            listBox.DropdwonByContainsText();
            Test.Log(Status.Info, "Selected " + EmployeeName + " as Name of Employee");


        }

        public void EnterUserName()
        {
            UserNameXpath.SendKeysExtension(UserName);
            Test.Log(Status.Info, "Selected " + UserName +  " as UserName");

        }

        public void EnterUserPassword()
        {
            IList<IWebElement> webElements = GetLists(PasswordFields);
            IWebElement element= webElements[0];
            element.SendKeysByElement(Password);
            Test.Log(Status.Info, "Entered User Password");
        }

        public void EnterPasswordAgain()
        {
            IList<IWebElement> webElements = GetLists(PasswordFields);
            IWebElement element = webElements[1];
            element.SendKeysByElement(Password);
            Test.Log(Status.Info, " Entered User Password Again");

        }

        public void ClickOnSubmitButton()
        {
            //SubmitButton.FindElementExtension();
            //SubmitButton.WdHighlight();
            ClickonSearchUserButton();
            Test.Log(Status.Info, " Click on Submit Button");

        }
    }
}
