using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Task2
{
    class Chrome
    {
        private IWebDriver driver;
        public void Intialize()
        {
            driver = new ChromeDriver();
        }
        public void OpenAppTest()
        {
            driver.Url = "https://demoqa.com/";
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://demoqa.com");        
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
