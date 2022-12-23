using OpenQA.Selenium;
using UtilityLibrary.ExtensionMethods;
using UtilityLibrary.PageUtility;

namespace OrangeHRMPages
{
    public class BasePage : PageUtility
    {
        private By SearchUser => By.XPath("//button[@type='submit']");
        private By ResetUsers => By.XPath("//button[@class='oxd-button oxd-button--medium oxd-button--ghost']");
        private By AddUsers => By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[1]/button");
        private By TableXpath => By.XPath("//div[@class='oxd-table-card']");
        private By UserNamesXpath => By.XPath("//div[@class='oxd-table-card']/div/div[2]");
       
        public void ClickonAddUserButton()
        {
            AddUsers.HighlightElement();
            AddUsers.ClickExtension();
        }

        public void ClickonSearchUserButton()
        {
            
            SearchUser.HighlightElement();
            SearchUser.ClickExtension();
        }

        public void ClickonResetUsersButton()
        {
            ResetUsers.HighlightElement();
            ResetUsers.ClickExtension();
        }

        public IEnumerable<IWebElement> UserData()
        {
            return GetUserRecords(TableXpath);
        }
        
        public IWebElement UserNamesByIdx(int idx)
        {
            
            UserNamesXpath.HighlightElement();
            return driver.FindElements(UserNamesXpath).ElementAt(idx);
        }

        
    }
}
