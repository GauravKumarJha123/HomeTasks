using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.ExtensionMethods;

namespace OrangeHRMPages.Pages.Admin
{
    public class AdminPage : BasePage
    {
        public AddUserPage addUserPage { get; set; } = new AddUserPage();

        public SearchUserPage searchUserPage { get; set; } = new SearchUserPage();
        private By AdminTab => By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a");

        //a[@class='oxd-main-menu-item active']

        public void ClickOnAdminTab()
        {
            ClickWrapper(AdminTab);
        }

        

    }
}
