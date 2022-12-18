using OpenQA.Selenium.Support.UI;
using UtilityLibrary.Selenium;

namespace UtilityLibrary.ExtensionMethods
{
    public static class WebDriverWaitExtension
    {
        static WebDriverWait wait;
        public static WebDriverWait LongerWait(this WebDriverWait webDriverWait)
        {
            wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(30));
            return wait;
        }

        public static WebDriverWait ShorterWait(this WebDriverWait webDriverWait)
        {
            wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(15));
            return wait;
        }
    }
}
