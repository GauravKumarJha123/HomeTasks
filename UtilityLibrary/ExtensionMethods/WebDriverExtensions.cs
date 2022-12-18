using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using UtilityLibrary.Selenium;
using static UtilityLibrary.Selenium.Navigation;// for staitic Fields
using System.Runtime.CompilerServices;

namespace UtilityLibrary.ExtensionMethods
{
    public static class WebDriverExtensions
    {
        private static IWebDriver _driver = Driver.driver;

        public static object WdHighlight(this By locator)
        {
            var myLocator = _driver.FindElement(locator);
            var js = (IJavaScriptExecutor)_driver;
            return js.ExecuteScript(weHighlightedColour, myLocator);
        }
        
        public static IWebElement WdFindElement(this By locator, int sec = 30)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(sec));
            return wait.Until(drv =>
            {
                try
                {
                    locator.WdHighlight();
                    return drv.FindElement(locator);
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
        }

        public static string[] SplitString(this By locator)
        {
            IWebElement el = locator.WdFindElement();
            string s = el.Text.ToString();
            string[] arr = s.Split(" to ");
            return arr;
        }

        public static void WdSendKeys(this By locator, string text, int sec = 30, bool clearFirst = false)
        {
            if (clearFirst) locator.WdFindElement(sec).Clear();
            locator.WdFindElement(sec).SendKeys(text);
        }

        public static void WdClickByIndex(this By locator, int index, int sec = 10)
        {
            var myLocator = _driver.FindElements(locator);
            myLocator[index].Click();
        }

        public static void WdDropdwonByText(this By element, string text)
        {
            IList<IWebElement> webElements = Driver.driver.FindElements(element);
            foreach(var autosug in webElements)
            {
                if (autosug.Text.Contains(text))
                {
                    autosug.Click();
                    break;
                }
            }
        }
        public static void WdDropdwonByContainsText(this By element)
        {
            IList<IWebElement> webElements = Driver.driver.FindElements(element);
            for(int i =0; i < webElements.Count(); i++)
            {
                IWebElement webElement = webElements[i];
                Thread.Sleep(3000);
                webElement.Click();
                break;
            }
        }
        public static void WdDropdwonByIdx(this By element, int idx = 0)
        {
            IList<IWebElement> webElements = Driver.driver.FindElements(element);
            for(int i = 0; i < idx;   i++)
            {
                if(i == idx)
                {
                    webElements[i].Click();
                    break;
                }   
            }
        }

        public static void WdClick(this By locator, int sec = 10)
        {
            locator.WdFindElement(sec).Click();
        }
    }
}
