using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTask7
{
    public class WebElements
    {
        public IWebElement searchBtn;
        public IWebElement val;
        public string searchVal;
        public IWebElement findBtn;
        public IWebElement searchResult;
        public string[] resultCnt;
        public ReadOnlyCollection<IWebElement> resultDesc;
    }
}
