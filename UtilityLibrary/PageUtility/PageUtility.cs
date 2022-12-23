using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UtilityLibrary.Selenium;
using UtilityLibrary.ExtensionMethods;

namespace UtilityLibrary.PageUtility
{
    public class PageUtility : DriverManager
    {

        public static void NavigatWrapper(string url)
        {
            driver.Navigate().GoToUrl(url);
            Maximize();
        }

        public static void ClickWrapper(By element)
        {
            element.ClickExtension();
        }

        public static void Maximize()
        {
            driver.Manage().Window.Maximize();
        }
        public static void ClearCookie()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }
        public static void ClearWrapper(By element)
        {
            driver.FindElement(element).Clear();
        }
        public static void SendKeysWrapper(By element, string text)
        {
            element.SendKeysExtension(text);
        }

        public void DropDownWrapper(By element)
        {

        }

        public static IWebElement GetElement(By element)
        {
            return driver.FindElement(element);
        }

        public static IWebElement WeFindElementByidx(By element , int idx)
        {
           return driver.FindElements(element).ElementAt(idx);
        }
        public static void HandleTable(By element, string text)
        {
            driver.FindElement(element).SendKeys(text);

        }
        public static IList<IWebElement> GetLists(By element)
        {
            return driver.FindElements(element);
        }

        public static IEnumerable<IWebElement> GetUserRecords(By element)
        {
            return driver.FindElements(element);
        }
    }
}
