using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.ExtensionMethods;

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
            RecruitmentTabXpath.WdHighlight();
            RecruitmentTabXpath.WdClick();
        }

        public void EnterFirstName()
        {
            IWebElement element = FirstNameXpath.FindElementExtension();
            element.WeSendKeys(firstName);
        }
        public void EnterLastName()
        {
            IWebElement element = LastNameXpath.FindElementExtension();
            element.WeSendKeys(lastName);
        }

        public void EnterEmailId()
        {
            IWebElement element = EmailXpath.FindElementExtension();
            element.WeSendKeys("xyz@email.com");
        }

        public bool VerifyTheName()
        {
            IWebElement nameElement = NameConfirmXpath.FindElementExtension();
            Console.WriteLine(nameElement.Text);
            return (nameElement.Text.ToString().Contains(firstName));
        }

        public bool VerifyRequiredField()
        {
            IWebElement el = RequiredFiledXpath.FindElementExtension();
            return el.WeElementIsDisplayed();
        }
    }
}
