using CSharpFramework.Utilities.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibrary.Utilities.PageUtility
{
    public class PageUtiltiy : DriverClass
    { 
        
          public static IWebElement GetElement(By element)
        {
            return CurrentDriver.FindElement(element);
        }     
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
        {   // log.info
            return CurrentDriver.FindElements(element);
        }
        public static void SendKeysWrapper(By element, string text)
        {
            
         CurrentDriver.FindElement(element).SendKeys(text);
            
        }
    }
}
