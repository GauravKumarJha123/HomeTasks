using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace Task7POM.Utilities
{
    public class PageUtility : BasePage
    {
        WebDriverWait wait = new WebDriverWait(CurrentDriver, TimeSpan.FromSeconds(15));

        public static void NavigatWrapper(string url)
        {
            CurrentDriver.Navigate().GoToUrl(url);

        }

        public static void ClickWrapper(By element)
        {
            CurrentDriver.FindElement(element).Click();
        }

        public void ClickOnText(By element, string text)
        {
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(element));
            IList<IWebElement> webElements = CurrentDriver.FindElements(element);
            foreach (var Seaches in webElements)
            {
                if (Seaches.Text.Equals(text))
                {
                    Seaches.Click();
                    break;
                }
            }
        }
        public void Maximize()
        {
            CurrentDriver.Manage().Window.Maximize();
        }

        public void CheckforCriteria(By element)
        {
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(element));
            IWebElement el = CurrentDriver.FindElement(element);
            string[] resultCnt = el.Text.Split(' ');
            if (Int32.Parse(resultCnt[0]) > 10)
            {
                Console.WriteLine("More than 10 results were found");
            }
        }

        public static IList<IWebElement> GetLists(By element)
        {
            return CurrentDriver.FindElements(element);
        }

        public static void SendKeysWrapper(By element, string text)
        {
            CurrentDriver.FindElement(element).SendKeys(text);
        }

        public static IWebElement GetElement(By element)
        {
            return CurrentDriver.FindElement(element);
        }
    }
}

