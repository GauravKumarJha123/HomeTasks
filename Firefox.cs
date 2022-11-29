using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Task3
{
    class Firefox
    {
        private IWebDriver driver;
        
        public void Intialize()
        {
            driver = new FirefoxDriver();
        }
        public void OpenAppTest()
        {
            //Navigating to Google's homepage

            driver.Navigate().GoToUrl("https://demoqa.com");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.CssSelector("img[alt='Selenium Online Training']")).Click();
         
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
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
