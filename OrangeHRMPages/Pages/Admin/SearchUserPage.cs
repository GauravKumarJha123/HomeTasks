using OpenQA.Selenium;
using UtilityLibrary.ExtensionMethods;

namespace OrangeHRMPages.Pages.Admin
{
    public class SearchUserPage : BasePage
    {

        private By UserNameXpath => By.XPath("(//input[@class='oxd-input oxd-input--active'])[2]");

        //(//div[@class='oxd-table-cell oxd-padding-cell'])[2]
        public void EnterUserName(string text)
        {
            
            UserNameXpath.SendKeysExtension(text);
        }
    }
}
