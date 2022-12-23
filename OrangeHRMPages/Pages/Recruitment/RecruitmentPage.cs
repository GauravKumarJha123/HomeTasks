using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.ExtensionMethods;
using static UtilityLibrary.Selenium.DriverManager;


namespace OrangeHRMPages.Pages.Recruitment
{
    public class RecruitmentPage : BasePage
    {
        private string firstName = "Gaurav";
        private string lastName = "Jha";
        private By RecruitmentTabXpath => By.XPath("//span[text()='Recruitment']");
        private By FirstNameXpath => By.XPath("//input[@name='firstName']");
        private By LastNameXpath => By.XPath("//input[@name='lastName']");
        private By EmailXpath => By.XPath("(//input[@class='oxd-input oxd-input--active'])[2]");
        private By NameConfirmXpath => By.XPath($"//div[contains(text(),'{firstName}')]");
        private By RequiredFiledXpath => By.XPath("//span[contains(string(),'Required')]");
        public void ClickOnRecruitmentTab()
        {
            RecruitmentTabXpath.FindElementExtension();
            RecruitmentTabXpath.HighlightElement();
            RecruitmentTabXpath.ClickExtension();
        }

        public void EnterFirstName()
        {
            IWebElement element = FirstNameXpath.FindElementExtension();
            element.SendKeysByElement(firstName);
            Test.Log(Status.Info, " Clicked On Recruitment Tab");

        }
        public void EnterLastName()
        {
            IWebElement element = LastNameXpath.FindElementExtension();
            element.SendKeysByElement(lastName);
            Test.Log(Status.Info, "Entered Last Name");

        }

        public void EnterEmailId()
        {
            IWebElement element = EmailXpath.FindElementExtension();
            element.SendKeysByElement("xyz@email.com");
            Test.Log(Status.Info, "Entered Email Id");

        }

        public bool VerifyTheName()
        {
            IWebElement nameElement = NameConfirmXpath.FindElementExtension();
            Console.WriteLine(nameElement.Text);

            if (nameElement.Text.ToString().Contains(firstName))
            {
                Test.Log(Status.Pass, "The Same User is added");
                return true;
            }
            Test.Log(Status.Fail, "The Same user is not added");
            return false;
        }

        public bool VerifyRequiredField()
        {
            IWebElement el = RequiredFiledXpath.FindElementExtension();
            if (el.ElementIsDisplayedExtension())
            {
                Test.Log(Status.Pass, "You cannpt Login Without Last Name");
                return true;
            }
            else
            {
                Test.Log(Status.Fail, "Are you a MAgician");
                return false;
            }
        }
    }
}
