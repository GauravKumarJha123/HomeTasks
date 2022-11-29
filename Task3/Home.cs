using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task3
{
    public class Home
    {
        static void Main(string[] args)
        {
            Firefox fireFoxClassObj = new Firefox();
            fireFoxClassObj.Intialize();
            fireFoxClassObj.OpenAppTest();
            fireFoxClassObj.EndTest();
            Chrome chromeClassObj = new Chrome();
            chromeClassObj.Intialize();
            chromeClassObj.OpenAppTest();
            chromeClassObj.EndTest();
            Console.ReadLine();
            
        }
    }
}