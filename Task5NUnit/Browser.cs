using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task5NUnit
{
    public class Browser
    {
        
        
        
        public void Test1(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(By.XPath("//*[@id=\"user-name\"]")).SendKeys("standard_user");
            driver.FindElement(By.XPath("//*[@id=\"password\"]")).SendKeys("secret_sauce");
            driver.FindElement(By.XPath("//*[@id=\"login-button\"]")).Click();
            IWebElement price = driver.FindElements(By.XPath("//*[@class=\"inventory_item_price\"]")).First();
            string priceText = price.Text;  
            driver.FindElement(By.XPath("//*[@id=\"add-to-cart-sauce-labs-backpack\"]")).Click();
            driver.FindElement(By.XPath("//*[@class=\"shopping_cart_badge\"]")).Click();
            IWebElement priceInCart = driver.FindElement(By.XPath("//div[@class='inventory_item_price']"));
            string priceInCartText = priceInCart.Text;
            Assert.That(priceText, Is.EqualTo(priceInCartText));
            driver.FindElement(By.XPath("//*[@id=\"checkout\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"first-name\"]")).SendKeys("Cool");
            driver.FindElement(By.XPath("//*[@id=\"last-name\"]")).SendKeys("Dude");
            driver.FindElement(By.XPath("//*[@id=\"postal-code\"]")).SendKeys("110001");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");

            driver.FindElement(By.XPath("//*[@id=\"continue\"]")).Click();
            js.ExecuteScript("window.scrollBy(0,500)", "");
            driver.FindElement(By.XPath("//*[@id=\"finish\"]")).Click();
        }
        [TearDown]
        public void End(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}