using CSharpFramework.Utilities.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityClassLib.Utilities.Selenium;

namespace UtilityLibrary.Utilities.PageUtility
{
    public class BasePage : PageUtiltiy
    {
        public IWebDriver driver = DriverClass.CurrentDriver;

        public string GetTitle => DriverClass.CurrentDriver.Title;

        public string GetUrl => DriverClass.CurrentDriver.Url;
        
        public string GetPageSource => DriverClass.CurrentDriver.PageSource;


        public void NavigateBaseUrl()
        {
            NavigatWrapper(Navigation.baseUrl);
            Maximize();
            Console.WriteLine(" :: The base URL is navigated to");
        }

        public void Start()
        {
            NavigateBaseUrl();
        }

       

    }
}
