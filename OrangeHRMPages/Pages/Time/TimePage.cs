using OpenQA.Selenium;
using UtilityLibrary.ExtensionMethods;
using UtilityLibrary.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRMPages.Pages.Time
{
    public class TimePage : BasePage
    {
        private By TimeTab => By.XPath("//span[text()='Time']");
        private By EmployeeNameXpath => By.XPath("(//div[@class=\"oxd-table-card\"]/div/div)[1]");
        private By EmployeeNameEnterXpath => By.XPath("//input[@placeholder='Type for hints...']");
        private By listBox => By.XPath("//div[@role='listbox']");

        private By submitXathConfirm => By.XPath("(//div[@class='oxd-table-card'])/div/div/div");
        //private By TimeSheetCheckXpath => By.XPath("//p[contains(text(),'No Timesheets Found')]");

        public void ClickOnTimeTab()
        {
            TimeTab.FindElementExtension();
            TimeTab.WdClick();
        }

        private string name;
        public void GetEmployee()
        {
            IWebElement el = EmployeeNameXpath.FindElementExtension();
            if (el != null)
            {
                name = el.Text.ToString();
            }
        }

        public void EnterEmployeeName()
        {
            EmployeeNameEnterXpath.WdHighlight();
            EmployeeNameEnterXpath.SendKeysExtension(name);
            //listBox.WdHighlight();
            Thread.Sleep(2000);
            listBox.DropdwonByContainsTextExtension();
        }

        public bool VerifyEmployeeTimesheet()
        {
            submitXathConfirm.WdHighlight();
            IWebElement el = submitXathConfirm.FindElementExtension();
            return (el.Text.ToString().Contains("Submit"));
        }
    }
}
