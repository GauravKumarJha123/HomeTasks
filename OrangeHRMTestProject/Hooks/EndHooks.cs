using TechTalk.SpecFlow;
using UtilityLibrary.Selenium;

namespace OrangeHRMTestProject.Hooks
{
    internal class EndHooks
    {
        [AfterScenario("Admin")]
        [AfterScenario("Admin01")]
        internal static void AfterTestRun()
        {
            Driver.driver.Quit();
        }
    }
}
