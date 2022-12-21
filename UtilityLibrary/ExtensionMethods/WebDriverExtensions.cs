using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using UtilityLibrary.Selenium;
using static UtilityLibrary.Selenium.Navigation;// for staitic Fields
using System.Runtime.CompilerServices;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;

namespace UtilityLibrary.ExtensionMethods
{
    public static class WebDriverExtensions
    {
        private static IWebDriver _driver = DriverManager.driver;

        public static object WdHighlight(this By locator)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
            var myLocator = _driver.FindElement(locator);
            var js = (IJavaScriptExecutor)_driver;
            return js.ExecuteScript(weHighlightedColour, myLocator);
        }
        
        public static IWebElement FindElementExtension(this By locator, int sec = 90)
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
            IWebElement el = locator.FindElementExtension();
            string s = el.Text.ToString();
            string[] arr = s.Split(" to ");
            return arr;
        }

        public static void SendKeysExtension(this By locator, string text, int sec = 60, bool clearFirst = true)
        {
            if (clearFirst) locator.FindElementExtension(sec).Clear();
            locator.FindElementExtension(sec).SendKeys(text);
        }
        public static void SendKeysClear(this By element, string text)
        {
            Actions actions = new Actions(DriverManager.driver);
            actions.MoveToElement(DriverManager.driver.FindElement(element)).DoubleClick().Click().SendKeys(Keys.Backspace).SendKeys(text).SendKeys(Keys.Tab).Build().Perform();
        }

        public static void WdClickByIndex(this By locator, int index, int sec = 10)
        {
            var myLocator = _driver.FindElements(locator);
            myLocator[index].Click();
        }

        public static void DropdwonByText(this By element, string text)
        {
            IList<IWebElement> webElements = DriverManager.driver.FindElements(element);
            foreach(var autosug in webElements)
            {
                if (autosug.Text.Contains(text))
                {
                    autosug.Click();
                    break;
                }
            }
        }
        public static void DropdwonByContainsText(this By element)
        {
            IList<IWebElement> webElements = DriverManager.driver.FindElements(element);
            for(int i =0; i < webElements.Count(); i++)
            {
                IWebElement webElement = webElements[i];
                webElement.WeElementToBeClickable();
                webElement.WeHighlightElement();
                webElement.Click();
                break;
            }
        }
        public static void DropdwonByContainsTextExtension(this By element)
        {
                IWebElement webElement = element.FindElementExtension();
                webElement.WeElementToBeClickable();
                webElement.WeHighlightElement();
                webElement.Click();
               
        }
        public static void WdDropdwonByIdx(this By element, int idx = 0)
        {
            IList<IWebElement> webElements = DriverManager.driver.FindElements(element);
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
            locator.FindElementExtension(sec).Click();
        }
    }
}
