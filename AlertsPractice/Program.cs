using Alerts_NUnit;
using OpenQA.Selenium.Chrome;

namespace AlertsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChromeTests c = new ChromeTests();
            c.Setup();
            c.Alerts();
            c.TimerAlerts();
            c.PromptAlert();
            c.ConfirmAlerts();
            c.ElementsTest();
            c.Frames();
            c.NewTab();
            c.NewWindow();
            c.NewWindowWithText();
            c.End();

        }
    }
}