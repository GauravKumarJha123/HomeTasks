using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UtilityClassLib.Utilities.Selenium;

namespace UtilityClassLib.ExtensionMethods
{

    public static class WebDriverExtensions
    {

        private static IWebDriver _driver = BasePage.CurrentDriver;       

        public static void ClickByIndex(this By locator, int idx = 0)
        {
            var mylocator = _driver.FindElements(locator);
            mylocator[idx].Click();
        }

        public static bool ElementDisplayed(this IWebElement element, int sec)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(sec));
            return wait.Until(drv =>
            {
                try
                {
                    return element.Displayed;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }

            });
        }
        public static void CustomClickWithWait(this IWebElement element , int sec )
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds((sec)));
            wait.Until(c => element.Enabled);
        }
    }
}
