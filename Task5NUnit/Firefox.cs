using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace Task5NUnit
{
    public class Firefox
    {
        Browser b = new Browser();
        public IWebDriver driver;
        [SetUp]
        public void Start()
        {
            driver = new FirefoxDriver();

        }
        [Test]
        public void Test3()
        {
            b.Test1(driver);
            b.End(driver);
        }

    }
}
