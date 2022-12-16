using UtilityClassLib.Utilities.Selenium;
using OpenQA.Selenium;

namespace UtilityLibrary.Utilities.PageUtility
{
    public class PageUtiltiy : BasePage
    {
        public static void NavigatWrapper(string url)
        {
            CurrentDriver.Navigate().GoToUrl(url);
        }

        public static void ClickWrapper(By element)
        {
            CurrentDriver.FindElement(element).Click();
        }

        public void Maximize()
        {
            CurrentDriver.Manage().Window.Maximize();
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

        public static By GetXpathUsingID(string value)
        {
            return By.XPath($"//*[@id=\"{value}\"]");
        }

        public static By GetXpathUsingDivClass(string value)
        {
            return By.XPath($"//div[@class='{value}']");
        }

        public static By GetByID(string value)
        {
            return By.Id($"{value}");
        }

    }
}
