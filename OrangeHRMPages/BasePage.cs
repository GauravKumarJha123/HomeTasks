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
        //private IEnumerable<IWebElement> UsersRecord { get; set; }
        private By TableXpath => By.XPath("//div[@class='oxd-table-card']");

        private By UserNamesXpath => By.XPath("//div[@class='oxd-table-card']/div/div[2]");
        //div[contains(text(),'Acolak')]  --> for user records

        private By PartiCularUser => By.XPath("//div[contains(text(),'Acolak')]");
        //div[@class='oxd-table-card']/div/div[2]  --> for user names in records

        //div[@class='oxd-table-card --mobile']
        //div[@class='oxd-table']
        public void ClickonAddUserButton()
        {
            ClickWrapper(AddUsers);
        }

        public void ClickonSearchUserButton()
        {
            ClickWrapper(SearchUser);
        }

        public void ClickonResetUsersButton()
        {
            ClickWrapper(ResetUsers);
        }

        public IEnumerable<IWebElement> UserData()
        {
            return GetUserRecords(TableXpath);  
        }

        public IWebElement UserNamesByIdx(int idx) {

            Thread.Sleep(5000);

            return driver.FindElements(UserNamesXpath).ElementAt(idx);
        }
    }
}
