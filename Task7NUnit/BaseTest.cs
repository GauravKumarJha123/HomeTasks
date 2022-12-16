using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7POM.Utilities;

namespace Task7NUnit
{
    public class BaseTest : BasePage
    {

        [SetUp]
        public void Setup() {
            
            StartBrowser();
        }

        [TearDown] public void Teardown()
        {
            EndBrowser();
        }
    }
}
