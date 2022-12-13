using CSharpFramework.Utilities.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibrary.Utilities.PageUtility
{
    public class PageUtiltiy
    {
          public static IWebElement GetElement(By element)
        {
            return DriverClass.CurrentDriver.FindElement(element);
        }     
        public static void NavigatWrapper(string url)
        {

            DriverClass.CurrentDriver.Navigate().GoToUrl(url);
        }

        public static void ClickWrapper(By element)
        {
            DriverClass.CurrentDriver.FindElement(element).Click();
        }

        public void Maximize()
        {
            DriverClass.CurrentDriver.Manage().Window.Maximize();
        }

        public static IList<IWebElement> GetLists(By element)
        {   // log.info
            return DriverClass.CurrentDriver.FindElements(element);
        }
        public static void SendKeysWrapper(By element, string text)
        {
            
         DriverClass.CurrentDriver.FindElement(element).SendKeys(text);
            
        }
    }
}
