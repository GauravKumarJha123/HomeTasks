using OpenQA.Selenium;
using UtilityLibrary.ExtensionMethods;
using SeleniumExtras.WaitHelpers;
using static UtilityLibrary.Selenium.DriverManager;
using static System.Net.Mime.MediaTypeNames;
using AventStack.ExtentReports;

namespace OrangeHRMPages.Pages.Leave
{
    public class LeavePage : BasePage
    {
        private string fromDate , toDate ;
        private By DateXpath => By.XPath("(//div[@class=\"oxd-table-card\"]/div/div)[2]");

        private By LeaveTab => By.XPath("//span[text()='Leave']");

        private By FromDateXpath => By.XPath("(//input[@placeholder=\"yyyy-mm-dd\"])[1]");

        private By ToDateXpath => By.XPath("(//input[@placeholder=\"yyyy-mm-dd\"])[2]");

        public void ClickOnLeaveTab()
        {
            LeaveTab.HighlightElement();
            LeaveTab.ClickExtension();
            Test.Log(Status.Info, " Clicked On Leave Tab");

        }

        public void GetDates()
        {
            DateXpath.HighlightElement();
            IWebElement el = DateXpath.FindElementExtension();
            string[] arr = DateXpath.SplitStringExtension();
            if (arr.Length > 1)
            {
                fromDate= arr[0];
                toDate= arr[1];
            }
            else
            {
                fromDate = arr[0];
                toDate = arr[0];
            }
            Test.Log(Status.Info, " Fetched Dates are" + fromDate + " and " + toDate);

        }

        public void EnterDates()
        {
            FromDateXpath.HighlightElement();
            FromDateXpath.SendKeysClearExtension(fromDate);
            ToDateXpath.HighlightElement();
            ToDateXpath.SendKeysClearExtension(toDate);
            Test.Log(Status.Info, " Entered Dates " + fromDate + " and " + toDate);

        }

        public bool verifyRecords()
        {
            //Thread.Sleep(5000);
            DateXpath.HighlightElement();
            IWebElement el = DateXpath.FindElementExtension();
            string[] arr = DateXpath.SplitStringExtension();
            if (arr[0].Equals(fromDate) ){
                Console.WriteLine(arr[0]);
                Test.Log(Status.Info, " VErified Dates are " + arr[0]);

                return true;

            }


            return false;
        }

        
    }
}
