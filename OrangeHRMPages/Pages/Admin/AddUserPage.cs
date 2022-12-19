using AngleSharp.Html.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Runtime.CompilerServices;
using UtilityLibrary.ExtensionMethods;
using static OrangeHRMPages.Support.Misc;

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
            IWebElement el = UserRoleXpath.WdFindElement();
            //el.WeElementIsEnabled();
            el.WeClick();
            listBox.WdDropdwonByText(AdminUser);
        }

        public void SelectStatus()
        {
            IWebElement el = StatusXpath.WdFindElement();
            //el.WeElementIsEnabled();
            el.WeClick();
            listBox.WdDropdwonByText(StatusEnabled);
        }

        public void SelectEmployeeName()
        {
            SendKeysWrapper(EmployeeNameXpath,EmployeeName);
            listBox.WdDropdwonByContainsText();
        }

        public void EnterUserName()
        {
            UserNameXpath.WdSendKeys(UserName);
        }

        public void EnterUserPassword()
        {
            IList<IWebElement> webElements = GetLists(PasswordFields);
            IWebElement element= webElements[0];
            element.WeSendKeys(Password);
        }

        public void EnterPasswordAgain()
        {
            IList<IWebElement> webElements = GetLists(PasswordFields);
            IWebElement element = webElements[1];
            element.WeSendKeys(Password);
        }

        public void ClickOnSubmitButton()
        {
           SubmitButton.WdClick();
        }
    }
}
