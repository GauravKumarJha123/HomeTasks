using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7POM.Pages;

namespace Task7NUnit.NUnitTest
{
    public class ResultPageTest : BaseTest
    {
        
        
        [Test]
        public void Test2()
        {
           
            SearchPageTest test = new SearchPageTest();
            test.Test1();
            ResultPage resultPage = new ResultPage();
            resultPage.CheckforCount();
        }
    }
}
