using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UtilityLibrary.Utilities.PageUtility;

namespace CSharpFramework.Steps
{
    [Binding]
    public class BaseSteps 
    {
        private BasePage basePage = new BasePage();

        [Given(@"a user is on the base page")]
        public void GivenAUserIsOnTheBasePage()
        {
            basePage.Start();
        }
        [Then(@"they see the page title contains ""(.*)""")]
        public void ThenIseeThePageTitleContains(string expectedTitle)
        {
            var titleToValidate = basePage.GetTitle.Contains(expectedTitle);
            Assert.IsTrue(titleToValidate, " :: The actual page title is different");
            Console.WriteLine(" :: The actual page title is " + titleToValidate);
        }

        [Then(@"the page URL contains ""(.*)""")]
        public void ThenISeeThePageUrlContains(string expectedUrl)
        {
            var urlToValidate = basePage.GetUrl.Contains(expectedUrl);
            Assert.IsTrue(urlToValidate, " :: The actual page Url is different");
            Console.WriteLine(" :: The actual page URL is " + urlToValidate);
        }

        [Then(@"they see ""(.*)"" in the PageSource")]
        public void ThenISeeInThePageSource(string expectedText)
        {
            var pageSourceTextToValidate = basePage.GetPageSource.Contains(expectedText);
            Assert.IsTrue(pageSourceTextToValidate, " :: The expected string is not present in the page source");
            Console.WriteLine(" :: The page source does not contain " + expectedText);
        }

        [Then(@"they see")]
        public void ThenISee(Table table)
        {
            foreach (var row in table.Rows)
            {
                var textToValidate = row["expectedText"];
                Assert.IsTrue(basePage.GetPageSource.Contains(textToValidate), textToValidate + " is not in the PageSource!");
                Console.WriteLine(":: The text " + textToValidate + " is in the PageSource ");
            }
        }
    }
}
