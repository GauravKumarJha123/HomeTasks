using OpenQA.Selenium;
using UtilityLibrary.ExtensionMethods;
using UtilityLibrary.Selenium;

namespace OrangeHRMPages.Pages.Time
{
    public class TimePage : BasePage
    {
        private By TimeTab => By.XPath("//span[text()='Time']");

        private By EmployeeNameXpath => By.XPath("(//div[@class=\"oxd-table-card\"]/div/div)[1]");

        private By EmployeeNameEnterXpath => By.XPath("//input[@placeholder='Type for hints...']");

        private By listBox => By.XPath("//div[@role='listbox']");

        //private By TimeSheetCheckXpath => By.XPath("//p[contains(text(),'No Timesheets Found')]");

        public void ClickOnTimeTab()
        {
            TimeTab.WdFindElement();
            TimeTab.WdClick();
        }

        private string name;
        public void GetEmployee()
        {
            IWebElement el = EmployeeNameXpath.WdFindElement();
            if (el != null)
            {
                name = el.Text.ToString();
            }
        }

        public void EnterEmployeeName()
        {
            SendKeysWrapper(EmployeeNameEnterXpath, name);
            listBox.WdDropdwonByContainsText();
            Thread.Sleep(5000);
        }

        public bool VerifyEmployeeTimesheet()
        {
            return (!Driver.driver.Url.Equals(Navigation.BeforeTimeSheetUrl));

        }
    }
}
