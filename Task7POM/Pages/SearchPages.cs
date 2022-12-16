using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7POM.Utilities;

namespace Task7POM.Pages
{
    public class SearchPage : PageUtility
    {
        #region locators
        private By searchBtn => By.XPath("//button[@class='header-search__button header__icon']");
        private By findBtn => By.XPath("//button[contains(text(),'Find')]");
        private By frequentSearches => By.XPath("//li[@class='frequent-searches__item']");
        #endregion

        #region Actions

        public void StartTest()
        {
            NavigatWrapper(Navigation.Url);
            Maximize();
        }
        public void ClickOnSearchButton()
        {
            ClickWrapper(searchBtn);
        }

        public void SeacrhForElement()
        {
            ClickOnText(frequentSearches, "DevOps");
        }

        public void ClickOnFindButton()
        {
            ClickWrapper(findBtn);
        }

        #endregion
    }
}
