using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityClassLib.ExtensionMethods
{
    public class MyTimeSpan
    {
        public  TimeSpan SmallWait
        {
            get { return TimeSpan.FromSeconds(3);}
        }
        public  TimeSpan NormalWait
        {
            get { return TimeSpan.FromSeconds(5); }

        }
        public  TimeSpan LongWait
        {
            get { return TimeSpan.FromSeconds(10); }

        }
    }
}
