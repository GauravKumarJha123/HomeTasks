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
        private string name = firstName + " " + lastName;

        private By RecruitmentTabXpath => By.XPath("//span[contains(text(),'Recruitment')]");

        private By FirstNameXpath => By.XPath("//input[@name='firstName']");

        private By LastNameXpath => By.XPath("//input[@name='lastName']");

        private By EmailXpath => By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[3]/div/div[1]/div/div[2]/input");

        private By NameConfirmXpath => By.XPath($"//div[contains(text(),'{name}')]");

        private string firstName = "Gaurav";
        private string lastName = "Jha";
        private string name = firstName + " " + lastName;
        public void ClickOnRecruitmentTab()
        {
            RecruitmentTabXpath.WdHighlight();
            RecruitmentTabXpath.WdClick();
        }

        public void EnterFirstName()
        {
            IWebElement element = FirstNameXpath.WdFindElement();
            element.WeSendKeys(firstName);
        }
        public void EnterLastName()
        {
            IWebElement element = LastNameXpath.WdFindElement();
            element.WeSendKeys(name);
        }

        public void EnterEmailId()
        {
            IWebElement element = EmailXpath.WdFindElement();
            element.WeSendKeys("xyz@email.com");
        }

        public void VerifyTheName()
        {
            IWebElement nameElement = FirstNameXpath.WdFindElement();
            if (nameElement.Text.ToString().Contains(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
