using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using UtilityLibrary.Selenium;
using static UtilityLibrary.Selenium.Navigation;// for staitic Field
using AngleSharp.Html.Dom;
using AngleSharp.Dom;
using AngleSharp.Html.Dom.Events;
using System.ComponentModel.Design;
using System.Net.Sockets;

namespace UtilityLibrary.ExtensionMethods
{
    public static class WebElementExtensions
    {
        private static IWebDriver _driver = DriverManager.driver;

        public static void WeHighlightElement(this IWebElement element)
        {
            var js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript(weHighlightedColour, element);
        }
        
        public static bool WeElementIsEnabled(this IWebElement element, int sec = 30)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(sec));
            return wait.Until(d =>
            {
                try
                {
                    element.WeHighlightElement();
                    return element.Enabled;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            });
        }

        public static void WeSelectDropdownOptionByText(this IWebElement element, string text, int sec = 10)
        {
            element.WeElementIsEnabled();
            new SelectElement(element).SelectByText(text);
        }
        //public static void WeInputDropDownByText(this IWebElement element, string text, int sec = 10)
        //{
        //    element.WeElementIsEnabled();
        //    new SelectElement
        //}

        public static void WeSelectDropdownOptionByValue(this IWebElement element, string value, int sec = 30)
        {
            element.WeElementIsEnabled(sec);
            new SelectElement(element).SelectByValue(value);
        }
        public static void WeSelectDivDropdownOptionByValue(this IWebElement element, string value, int sec = 30)
        {
            element.WeElementIsEnabled(sec);
        }

        public static string WeGetAttribute(this IWebElement element, string attribute)
        {
            return element.GetAttribute(attribute);
        }
        
        public static bool WeElementIsDisplayed(this IWebElement element, int sec = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(sec));
            return wait.Until(d =>
            {
                try
                {
                    element.WeHighlightElement();
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            });
        }
        public static bool WeIListIsDisplayed(this IList<IWebElement> element,int idx, int sec = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(sec));
            return wait.Until(d =>
            {
                try
                {
                    element[idx].WeHighlightElement();
                    return element[idx].Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            });
        }

        public static void WeElementIListByIndex(this IList<IWebElement> elements, int idx = 0)
        {
            elements.ElementAt(idx).Click();
        }

        public static void WeSendKeys(this IWebElement element, string text, int sec = 10, bool clearFirst = false)
        {
            element.WeElementIsDisplayed(sec);
            if (clearFirst) element.Clear();
            element.SendKeys(text);
        }

        public static void WeElementToBeClickable(this IWebElement element, int sec = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(sec));
            wait.Until(c => element.Enabled);
        }

        public static void WeClick(this IWebElement element, int sec = 10)
        {
            element.WeElementToBeClickable();
            element.WeHighlightElement();
            element.Click();
        }

        public static void WeSwitchTo(this IWebElement iframe, int sec = 10)
        {
            iframe.WeElementToBeClickable(sec);
            iframe.WeHighlightElement();
            _driver.SwitchTo().Frame(iframe);
        }
    }
}
