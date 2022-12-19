using TechTalk.SpecFlow;
using UtilityLibrary.Selenium;

namespace OrangeHRMTestProject.Hooks
{
    internal class EndHooks
    {
        
        internal static void AfterTestRun()
        {
            Driver.driver.Quit();
        }
    }
}
