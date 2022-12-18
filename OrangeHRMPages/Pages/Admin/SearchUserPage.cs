using OpenQA.Selenium;
using UtilityLibrary.ExtensionMethods;

namespace OrangeHRMPages.Pages.Admin
{
    public class SearchUserPage : BasePage
    {

        private By UserNameXpath => By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/input");

        public void EnterUserName(string text)
        {
            
            UserNameXpath.WdSendKeys(text);
        }
    }
}
