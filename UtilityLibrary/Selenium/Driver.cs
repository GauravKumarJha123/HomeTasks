using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using UtilityLibrary.Selenium;

namespace UtilityLibrary.Selenium
{
    public class Driver
    {
        public static WebDriverWait wait;
        [ThreadStatic]
        public static IWebDriver driver;

        public static void InitChrome()
        {
            driver = new ChromeDriver();
        }

        public static void InitFirefox()
        {
            driver = new FirefoxDriver();
        }

    }
}
