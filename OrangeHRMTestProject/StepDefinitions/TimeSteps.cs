using NUnit.Framework;
using OrangeHRMPages.Pages.Time;
using TechTalk.SpecFlow;

namespace OrangeHRMTestProject.StepDefinitions
{
    [Binding]
    public sealed class TimeSteps
    {
        TimePage timePage = new TimePage();
        
        [When(@"I Click on Time Tab")]
        public void WhenIClickOnTimeTab()
        {
            timePage.ClickOnTimeTab();
        }

        [When(@"I Fetch User Data")]
        public void WhenIFetchUserData()
        {
            timePage.GetEmployee();
        }

        [When(@"I Enter User Name")]
        public void WhenIEnterUserName()
        {
            timePage.EnterEmployeeName();
        }

        [When(@"I Click on View Button")]
        public void WhenIClickOnViewButton()
        {
            timePage.ClickonSearchUserButton();
        }


        [Then(@"I Should Get The Timesheet of Employee")]
        public void ThenIShouldGetTheTimesheetOfEmployee()
        {
            if (timePage.VerifyEmployeeTimesheet())
            {
                Assert.Pass("TimeSheet Step done");
            }
            else
            {
                Assert.Fail("No TimeSheet Fouund for given Employee");
            }
        }
    }
}
