
using NUnit.Framework;
using OrangeHRMPages.Pages.Leave;
using TechTalk.SpecFlow;

namespace OrangeHRMTestProject.StepDefinitions
{
    [Binding]
    public sealed class LeaveSteps
    {
        private LeavePage leavePage = new LeavePage();
        [When(@"I Click on Leave Tab")]
        public void WhenIClickOnLeaveTab()
        {
            leavePage.ClickOnLeaveTab();
        }

        [When(@"I Fetch Leave Date")]
        public void WhenIFetchLeaveDate()
        {
            leavePage.GetDates();
        }

        [When(@"I Enter Leave Date")]
        public void WhenIEnterLeaveDate()
        {
            leavePage.EnterDates();
        }

        [When(@"I Click on SearchButton")]
        public void WhenIClickOnSearchButton()
        {
            leavePage.ClickonSearchUserButton();

        }
        [Then(@"I get the User")]
        public void ThenIGetTheUser()
        {
            leavePage.verifyRecords();
        }


    }
}
