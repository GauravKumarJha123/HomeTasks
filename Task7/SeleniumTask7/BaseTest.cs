using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeleniumTask7
{
    public class BaseTest : WebElements
    {
        public IWebDriver driver;

        
        public virtual void Start()
        {
            
        }
        //protected IWebDriver GetDriver() {  return driver; }
        
        public void SearchResult()
        {
            driver.Navigate().GoToUrl("https://www.epam.com/");
            driver.Manage().Window.Maximize();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//button[@class='header-search__button header__icon']")));
            searchBtn = driver.FindElement(By.XPath("//button[@class='header-search__button header__icon']"));
            searchBtn.Click();
            // page wait for drop down
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//li[@class='frequent-searches__item']")));
            val = driver.FindElements(By.XPath("//li[@class='frequent-searches__item']")).ElementAt(2);
            searchVal = val.Text;
            val.Click();

            findBtn = driver.FindElement(By.XPath("//button[contains(text(),'Find')]"));
            findBtn.Click();
            // wait for search results counter
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//h2[@class='search-results__counter']")));
            searchResult = driver.FindElement(By.XPath("//h2[@class='search-results__counter']"));
            resultCnt = searchResult.Text.Split(' ');
            if (Int32.Parse(resultCnt[0]) > 10)
            {
                Console.WriteLine("More than 10 results were found");
            }

            resultDesc = driver.FindElements(By.XPath("//p[@class='search-results__description']"));
            foreach (var descriptionText in resultDesc)
            {
                Assert.IsTrue(descriptionText.Text.Contains(searchVal) , " Not Found Devops in Decription");
            }

        }

        public void EndTest()
        {
            driver.Close();
        }
    }
}
