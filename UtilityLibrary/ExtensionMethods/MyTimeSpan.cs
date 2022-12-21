using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.Selenium;

namespace UtilityLibrary.ExtensionMethods
{
    public class MyTimeSpan
    {
        public static void Implicitwait(int sec = 30)
        {
            DriverManager.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(sec);
        }
        public static TimeSpan SmallWait
        {
            get { return TimeSpan.FromSeconds(3); }
        }
        public static TimeSpan NormalWait
        {
            get { return TimeSpan.FromSeconds(5); }

        }
        public static TimeSpan LongWait
        {
            get { return TimeSpan.FromSeconds(10); }

        }
    }
}
