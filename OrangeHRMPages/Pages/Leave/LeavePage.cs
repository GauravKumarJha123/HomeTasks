using OpenQA.Selenium;
using UtilityLibrary.ExtensionMethods;
using SeleniumExtras.WaitHelpers;

namespace OrangeHRMPages.Pages.Leave
{
    public class LeavePage : BasePage
    {
        private string fromDate , toDate ;
        private By DateXpath => By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[2]/div/div[2]/div/div/div[2]");

        private By LeaveTab => By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[3]/a/span");

        private By FromDateXpath => By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/div/div/input");

        private By ToDateXpath => By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[2]/div/div[2]/div/div/input");

        public void ClickOnLeaveTab()
        {
            wait = wait.ShorterWait();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(LeaveTab));
            LeaveTab.WdClick();
        }

        public void GetDates()
        {
            Thread.Sleep(3000);
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
            
        }

        public void EnterDates()
        {
            Thread.Sleep(2000);
            FromDateXpath.WdHighlight();
            FromDateXpath.WdSendKeys(fromDate);
            ToDateXpath.WdDropdwonByText(toDate);
        }

        public bool verifyRecords()
        {
            IWebElement el = DateXpath.WdFindElement();
            string[] arr = DateXpath.SplitString();
            if (arr[0].Equals(fromDate) ){
                return true;
            }

            return false;
        }

        
    }
}
