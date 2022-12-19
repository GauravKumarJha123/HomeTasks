using NUnit.Framework;
using OrangeHRMPages.Pages.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UtilityLibrary.Selenium;

namespace OrangeHRMTestProject.StepDefinitions
{
    [Binding]
    public sealed class RecruitmentSteps
    {
        RecruitmentPage recruitmentPage = new RecruitmentPage();

        [When(@"I Click on Recruitment Tab")]
        public void WhenIClickOnRecruitmentTab()
        {
            recruitmentPage.ClickOnRecruitmentTab();
        }

        [When(@"I Enter First Name")]
        public void WhenIEnterFirstName()
        {
            recruitmentPage.EnterFirstName();
        }

        [When(@"I Enter Last Name")]
        public void WhenIEnterLastName()
        {
            recruitmentPage.EnterLastName();
        }
        [When(@"I Enter EmailId")]
        public void WhenIEnterEmailId()
        {
            recruitmentPage.EnterEmailId();
        }


        [When(@"I Verify the Names")]
        public void WhenIVerifyTheNames()
        {
            if (recruitmentPage.VerifyTheName())
            {
                Assert.Pass("The Names are Matching");
            }
            else
            {
                Assert.Fail("The Names are not Matching");
            }
        }

        #region scenario 2

        [When(@"I Verify the Result")]
        public void WhenIVerifyTheResult()
        {
            if (recruitmentPage.VerifyRequiredField())
            {
                Assert.Pass("You cannpt Login Without Last Name");
            }
            else
            {
                Assert.Fail("Are you a MAgician");
            }
        }


        #endregion

    }
}
