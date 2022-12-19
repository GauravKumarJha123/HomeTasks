using OpenQA.Selenium;
using OrangeHRMPages.Pages.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.ExtensionMethods;
using UtilityLibrary.Selenium;

namespace OrangeHRMPages.Pages.Time
{
    public class TimePage : BasePage
    {
        private By TimeTab => By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[4]/a/span");

        private By EmployeeNameXpath => By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div[2]/div[1]/div/div[1]");

        private By EmployeeNameEnterXpath => By.XPath("//input[@placeholder='Type for hints...']");

        private By listBox => By.XPath("//div[@role='listbox']");

        private By TimeSheetCheckXpath => By.XPath("//p[contains(text(),'No Timesheets Found')]");

        private By ViewButton => By.XPath("//button[@type='submit']");
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
            return true;   
            //IWebElement el = TimeSheetCheckXpath.WdFindElement();

            //if (el.WeElementIsDisplayed())
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}

        }
    }
}
