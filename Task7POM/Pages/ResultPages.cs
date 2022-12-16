using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7POM.Utilities;

namespace Task7POM.Pages
{
    public class ResultPage : PageUtility
    {
        #region Locators
        private By SearchResultCounter => By.XPath("//h2[@class='search-results__counter']");

        //private By ResultDescription => By.XPath("//p[@class='search-results__description']");
        #endregion

        #region Actions

        public void CheckforCount()
        {
            CheckforCriteria(SearchResultCounter);
        }

        #endregion

    }
}
