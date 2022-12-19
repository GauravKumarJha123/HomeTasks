using OpenQA.Selenium;
using UtilityLibrary.ExtensionMethods;
using SeleniumExtras.WaitHelpers;

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

            LeaveTab.WdClick();
        }

        public void GetDates()
        {
            
            IWebElement el = DateXpath.WdFindElement();
            string[] arr = DateXpath.SplitString();
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
            Console.WriteLine(fromDate + " to " + toDate);
        }

        public void EnterDates()
        {
            bool clear = true;
            FromDateXpath.WdHighlight();
            FromDateXpath.WdSendKeysClear(fromDate);
            Thread.Sleep(5000);
            ToDateXpath.WdHighlight();
            ToDateXpath.WdSendKeysClear(toDate);
            Thread.Sleep(5000);
        }

        public bool verifyRecords()
        {
            Thread.Sleep(5000);
            IWebElement el = DateXpath.WdFindElement();
            string[] arr = DateXpath.SplitString();
            if (arr[0].Equals(fromDate) ){
                Console.WriteLine(arr[0]);

                return true;
            }
            Console.WriteLine(arr[0]);

            return false;
        }

        
    }
}
