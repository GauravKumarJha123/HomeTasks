using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5NUnit
{
    public class Chrome 
    {
        Browser b = new Browser();
        public IWebDriver driver;
        [SetUp]
        public void  Start()
        {
            driver = new ChromeDriver();
            
        }
        [Test]
        public void Test2()
        {
            b.Test1(driver);
            b.End(driver);
        }
        

    }
}
