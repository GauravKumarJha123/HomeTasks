using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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
    public class ChromeTests : BaseTest
    {
        
        [SetUp]
        public override void Start()
        {
            driver = new ChromeDriver();
        }
        [Test]
        [Parallelizable(ParallelScope.Self)]
        public void SearchTest()
        {
            SearchResult();
        }
        [TearDown]
        public void End()
        {
            EndTest();
        }

    }
}
