using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{                        
    class Chrome
    {
        IWebDriver driver;
        [SetUp]
        public void Intialize()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void OpenAppTest()
        {
            driver.Url = "https://demoqa.com/";
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://demoqa.com");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            IWebElement JoinButton = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("img[alt='Selenium Online Training']")));
            JoinButton.Click();


            String Title = driver.Title;
            int TitleLength = driver.Title.Length;
            Console.WriteLine("Title of the page " + Title);
            Console.WriteLine("Length of the Title " + TitleLength);
            String PageURL = driver.Url;
            int URLLength = PageURL.Length;
            Console.WriteLine("URL of the page is " + PageURL);
            Console.WriteLine("Length of the URL is " + URLLength);
            String PageSource = driver.PageSource;
            int PageSourceLength = driver.PageSource.Length;
            Console.WriteLine("Page Source of the page is " + PageSource);
            Console.WriteLine("Length of the Page Source is " + PageSourceLength);
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }




    }
}
