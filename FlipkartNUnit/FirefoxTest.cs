using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace FlipkartNUnit
{
    public class FirefoxTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Intialize()
        {
            driver = new FirefoxDriver();
        }
        [Test]
        public void Test2()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            IWebElement close = driver.FindElement(By.CssSelector("body > div._2Sn47c > div > div > button"));
            close.Click();
            Thread.Sleep(2000);
            bool groceryISVisible = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[1]/a/div[2]")).Displayed;
            bool mobilesISVisible = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[2]/a/div[2]")).Displayed;
            bool fashionsISVisible = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[3]/a/div[2]/div/div")).Displayed;
            bool electronicsISVisible = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[4]/a/div[2]/div/div")).Displayed;
            bool homeISVisible = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[5]/a/div[2]/div/div")).Displayed;
            bool appliancesISVisible = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[6]/a/div[2]")).Displayed;
            bool travelISVisible = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[7]/a/div[2]")).Displayed;
            bool topOffersISVisible = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[8]/a/div[2]")).Displayed;
            bool beautyISVisible = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[9]/a/div[2]/div/div")).Displayed;

            Assert.That(fashionsISVisible, Is.True, "fashion should be tab Displayed");
            Assert.IsTrue(groceryISVisible, "grocery should be tab Displayed");
            Assert.IsTrue(mobilesISVisible, "mobiles tab should be Displayed");
            Assert.IsTrue(electronicsISVisible, "electronics tab should be Displayed");
            Assert.IsTrue(homeISVisible, "home tab should be Displayed");
            Assert.IsTrue(travelISVisible, "travel tab should be Displayed");
            Assert.IsTrue(beautyISVisible, "beauty tab should be Displayed");
            Assert.IsTrue(appliancesISVisible, "appliances tab should be Displayed");

            Actions actions = new Actions(driver);
            IWebElement electronics = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[4]/a/div[2]/div/div"));
            actions.MoveToElement(electronics).Build().Perform();

            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            w.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText("Audio")));
            driver.FindElement(By.LinkText("Audio")).Click();
            //Thread.Sleep(2000);      
            w.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//body/div[@id='container']/div[1]/div[2]/div[1]/div[1]/span[2]")));
            IWebElement tv = driver.FindElement(By.XPath("//body/div[@id='container']/div[1]/div[2]/div[1]/div[1]/span[2]"));
            actions.MoveToElement(tv).Build().Perform();

            w.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.LinkText("Split ACs")));
            IWebElement ac = driver.FindElement(By.LinkText("Split ACs"));
            actions.MoveToElement(ac).Click().Build().Perform();
            Thread.Sleep(2000);
            w.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[contains(text(),'Showing 1 – 24')]")));
            bool isSplitAcDisplayed = driver.FindElement(By.XPath("//*[contains(text(),'Showing 1 – 24')]")).Displayed;
            Assert.IsTrue(isSplitAcDisplayed, "Split Ac Displayed");
            IWebElement priceElement = driver.FindElements(By.XPath("//div[@class='_30jeq3 _1_WHN1']")).First();
            string price = priceElement.Text;
            w.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("_1fQZEK")));
            IWebElement acElement = driver.FindElements(By.ClassName("_1fQZEK")).First();
            acElement.Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            w.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@class='_30jeq3 _16Jk6d']")));
            IWebElement newTabPrice = driver.FindElement(By.XPath("//*[@class='_30jeq3 _16Jk6d']"));
            string ans2 = newTabPrice.Text;
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Assert.That(price, Is.EqualTo(ans2));
        }

        [TearDown]
        public void End()
        {

            driver.Quit();
        }
    }
}
