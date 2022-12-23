using OpenQA.Selenium;
using UtilityLibrary.ExtensionMethods;
using UtilityLibrary.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using static UtilityLibrary.Selenium.DriverManager;
using AventStack.ExtentReports;

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
            TimeTab.ClickExtension();
            Test.Log(Status.Info, " Clicked On Time Tab");

        }

        private string name;
        public void GetEmployee()
        {
            IWebElement el = EmployeeNameXpath.FindElementExtension();
            if (el != null)
            {
                name = el.Text.ToString();
                Test.Log(Status.Info, "Got Employee name as "+ name);

            }
        }

        public void EnterEmployeeName()
        {
            EmployeeNameEnterXpath.HighlightElement();
            EmployeeNameEnterXpath.SendKeysExtension(name);
            //listBox.WdHighlight();
            Thread.Sleep(2000);
            Test.Log(Status.Info, "Entered Employee name as " + name);
            listBox.DropdwonByContainsTextExtension();
        }

        public bool VerifyEmployeeTimesheet()
        {
            submitXathConfirm.HighlightElement();
            IWebElement el = submitXathConfirm.FindElementExtension();


            if (el.Text.ToString().Contains("Submit"))
            {
                Test.Log(Status.Info, "Employee TimeSheet Found");
                return true;
            }
            else
            {
                Test.Log(Status.Info, "Employee Timesheet Not Found");
                return true;
            }
        }
    }
}
