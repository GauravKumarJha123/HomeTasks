using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7POM.Pages;

namespace Task7NUnit.NUnitTest
{
    public class SearchPageTest : BaseTest
    {
        [Test]
        public void Test1()
        {
            SearchPage searchPage = new SearchPage();

            searchPage.StartTest();
            searchPage.ClickOnSearchButton();
            searchPage.SeacrhForElement();
            searchPage.ClickOnFindButton();
        }

    }
}
