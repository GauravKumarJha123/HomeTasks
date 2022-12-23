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

        public static void HighlightWebElement(this IWebElement element)
        {
            var js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript(weHighlightedColour, element);
        }
        
        public static bool ElementIsEnabledExtension(this IWebElement element, int sec = 30)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(sec));
            return wait.Until(d =>
            {
                try
                {
                    element.HighlightWebElement();
                    return element.Enabled;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            });
        }

        public static void SelectDropdownOptionByText(this IWebElement element, string text, int sec = 10)
        {
            element.ElementIsEnabledExtension();
            new SelectElement(element).SelectByText(text);
        }
        //public static void WeInputDropDownByText(this IWebElement element, string text, int sec = 10)
        //{
        //    element.WeElementIsEnabled();
        //    new SelectElement
        //}

        public static void SelectDropdownOptionByValue(this IWebElement element, string value, int sec = 30)
        {
            element.ElementIsEnabledExtension(sec);
            new SelectElement(element).SelectByValue(value);
        }
        public static void SelectDivDropdownOptionByValue(this IWebElement element, string value, int sec = 30)
        {
            element.ElementIsEnabledExtension(sec);
        }

        public static string GetAttributeExtension(this IWebElement element, string attribute)
        {
            return element.GetAttribute(attribute);
        }
        
        public static bool ElementIsDisplayedExtension(this IWebElement element, int sec = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(sec));
            return wait.Until(d =>
            {
                try
                {
                    element.HighlightWebElement();
                    return element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            });
        }
        public static bool IListIsDisplayedExtension(this IList<IWebElement> element,int idx, int sec = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(sec));
            return wait.Until(d =>
            {
                try
                {
                    element[idx].HighlightWebElement();
                    return element[idx].Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            });
        }

        public static void ElementIListByIndex(this IList<IWebElement> elements, int idx = 0)
        {
            elements.ElementAt(idx).Click();
        }

        public static void SendKeysByElement(this IWebElement element, string text, int sec = 10, bool clearFirst = false)
        {
            element.ElementIsDisplayedExtension(sec);
            if (clearFirst) element.Clear();
            element.SendKeys(text);
        }

        public static void ElementToBeClickable(this IWebElement element, int sec = 10)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(sec));
            wait.Until(c => element.Enabled);
        }

        public static void ClickWebElement(this IWebElement element, int sec = 10)
        {
            element.ElementToBeClickable();
            element.HighlightWebElement();
            element.Click();
        }

        public static void SwitchToFrameExtension(this IWebElement iframe, int sec = 10)
        {
            iframe.ElementToBeClickable(sec);
            iframe.HighlightWebElement();
            _driver.SwitchTo().Frame(iframe);
        }
    }
}
