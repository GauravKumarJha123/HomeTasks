using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Net;

namespace Alerts_NUnit
{
    public class ChromeTests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void ElementsTest()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0,350)", "");
            //Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"app\"]//h5[contains(text(), 'Elements')]"));
            element.Click();

            js.ExecuteScript("window.scrollBy(0,12)", "");
            IWebElement textBox = driver.FindElement(By.XPath("//*[@id=\"item-0\"]/span[contains(text(), 'Text Box')]"));
            textBox.Click();
            js.ExecuteScript("window.scrollBy(0,120)", "");
            IWebElement userName = driver.FindElement(By.XPath("//*[@id=\"userName\"]"));
            userName.SendKeys("XYZ");
            IWebElement userEmail = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            userEmail.SendKeys("xyz@email.com");
            IWebElement currentAddress = driver.FindElement(By.XPath("//*[@id=\"currentAddress\"]"));
            currentAddress.SendKeys("27/703 street 5 Delhi");
            js.ExecuteScript("window.scrollBy(0,500)", "");

            IWebElement permanentAddress = driver.FindElement(By.XPath("//*[@id=\"permanentAddress\"]"));
            permanentAddress.SendKeys("27/703 street 5 Delhi");

            IWebElement submitButton = driver.FindElement(By.XPath("//*[@id=\"submit\"]"));
            submitButton.Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,120)", "");

            IWebElement checkBox = driver.FindElement(By.XPath("//*[@id=\"item-1\"]/span[contains(text(), 'Check Box')]"));
            checkBox.Click();
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(1211,329)", "");
            


        }
        [Test]
        public void Alerts()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(1248,372)", "");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"alertButton\"]")).Click();
            Thread.Sleep(2000);
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            Console.WriteLine("Alert -->  " + alertText);
            Thread.Sleep(2000);

            alert.Accept();


        }
        [Test]
        public void TimerAlerts()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollBy(0,0)", "");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"timerAlertButton\"]")).Click();
            Thread.Sleep(6000);
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            Console.WriteLine("Alert -->  " + alertText);
            Thread.Sleep(2000);
            alert.Accept();
        }
        [Test]
        public void ConfirmAlerts()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,120)", "");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"confirmButton\"]")).Click();
            Thread.Sleep(2000);
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            Console.WriteLine("Alert -->  " + alertText);
            Thread.Sleep(2000);
            alert.Accept();
        }
        [Test]
        public void PromptAlert()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,150)", "");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"promtButton\"]")).Click();
            Thread.Sleep(2000);
            IAlert alert = driver.SwitchTo().Alert();
            alert.SendKeys("Hey There I am Learning Selenium");
            alert.Accept();
            Thread.Sleep(2000);
            

        }
        [Test]
        public void Frames()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/frames");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,270)", "");
            Thread.Sleep(5000);
            IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
            //driver.SwitchTo().Frame(0);
            IWebElement iframeElement = driver.FindElement(By.Id("frame1"));

            //now use the switch command
            driver.SwitchTo().Frame(iframeElement);
            Thread.Sleep(3000);

            //Do all the required tasks in the frame 0
            //Switch back to the main window
            driver.SwitchTo().DefaultContent();
            Console.WriteLine("Current Frame is -->  " );
            Thread.Sleep(3000);

        }
        [Test]
        public void NewTab()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(1248,372)", "");
            Thread.Sleep(2000);
            IWebElement browserWindow = driver.FindElement(By.XPath("//span[normalize-space()='Browser Windows']"));
            browserWindow.Click();
            Thread.Sleep(2000);
            string originalWindow = driver.CurrentWindowHandle;

            IWebElement newTab = driver.FindElement(By.XPath("//*[@id=\"tabButton\"]"));
            newTab.Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);
            

            //Thread.Sleep(2000);
            //Assert.AreEqual(driver.WindowHandles.Count, 1);
            //IWebElement newWindow = driver.FindElement(By.XPath("//*[@id=\"windowButton\"]"));
            //newWindow.Click();
            //driver.Close();

            ////Switch back to the old tab or window
            //driver.SwitchTo().Window(originalWindow);
        }
        [Test]
        public void NewWindow()
        {   

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(1248,372)", "");
            Thread.Sleep(2000);
            IWebElement browserWindow = driver.FindElement(By.XPath("//span[normalize-space()='Browser Windows']"));
            browserWindow.Click();
            Thread.Sleep(2000);
            //string originalWindow = driver.CurrentWindowHandle;

            IWebElement newWindow = driver.FindElement(By.XPath("//*[@id=\"windowButton\"]"));
            newWindow.Click();
            Thread.Sleep(4000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);
            //*[@id="messageWindowButton"]
        }
        [Test]
        public void NewWindowWithText()
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(1248,372)", "");
            Thread.Sleep(2000);
            IWebElement browserWindow = driver.FindElement(By.XPath("//span[normalize-space()='Browser Windows']"));
            browserWindow.Click();
            Thread.Sleep(2000);
            //string originalWindow = driver.CurrentWindowHandle;

            IWebElement newWindowMessage = driver.FindElement(By.XPath("//*[@id=\"messageWindowButton\"]"));
            newWindowMessage.Click();
            Thread.Sleep(4000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);
            
        }
        [TearDown]
        public void End()
        {
            driver.Quit();
        }
    }
}