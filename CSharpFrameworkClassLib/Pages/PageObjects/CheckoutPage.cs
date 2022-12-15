using AventStack.ExtentReports;
using CSharpFramework.Utilities.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityClassLib.Utilities.Selenium;
using UtilityLibrary.Utilities.PageUtility;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class CheckoutPage : PageUtiltiy
    {
        #region Locators
        By itemsTitle => By.XPath("//div[@class='inventory_item_name']");// IList<IwEbEleem
        By itemsPrice => By.XPath("//div[@class='inventory_item_price']");// IList<IwEbEleem

        By firstName => By.Id("first-name");

        By lastName => By.Id("last-name");

        By zipCode => By.XPath("//input[@id='postal-code']");

        By continueBtn => By.XPath("//input[@id='continue']");

        By finishBtn => By.XPath("//button[@id='finish']");// IList<IwEbEleem

        //[FindsBy(How = How.XPath, Using = "//*[@id=\"checkout_summary_container\"]/div/div[2]/div[5]")]
        //private IWebElement totalPrice;
        //  --> price element 129.94


        #endregion

        #region locators
        public void FirstName(string user)
        {
            SendKeysWrapper(firstName, user);
            extentReport.test = extentReport.report.CreateTest("Checkout Test").Info("Checkout Test Started");
            extentReport.test.Log(Status.Info, "Logging was Sucess");
            extentReport.test.Log(Status.Info, "Adding Product was Sucess");
            extentReport.test.Log(Status.Info, "Navigated To Checkout Page");
            extentReport.test.Log(Status.Info, "First Name is entered");

        }
        public void LastName(string lname)
        {
            SendKeysWrapper(lastName, lname);
            extentReport.test.Log(Status.Info, "Last Name is entered");

        }
        public void ZipCode(string code)
        {
            SendKeysWrapper(zipCode, code);
            extentReport.test.Log(Status.Info, "ZipCode Name is entered");


        }
        public void ContinueButton()
        {
            ClickWrapper(continueBtn);
            extentReport.test.Log(Status.Info, "Continue Button is CLicked");

        }
        public void FinishButton()
        {
            ClickWrapper(finishBtn);
            extentReport.test.Log(Status.Info, "Finish Button is CLicked");
            
        }

        public void VerifyFinishPage()
        {
            if (DriverClass.CurrentDriver.Url.Equals(Navigation.finshPageUrl))
            {
                if (extentReport.test.Status == Status.Pass)
                    extentReport.test.Log(Status.Pass, "Checkout Test Passed");
                else
                    extentReport.test.Log(Status.Fail, "Checkout Failed");
            }
            else
            {
                extentReport.test.Log(Status.Fail, "Checkout Failed");
            }
        }
        #endregion


        #region Methods
        public IList<IWebElement> getItemsTitle()
        {
            return GetLists(itemsTitle);
        }
        public IList<IWebElement> getItemsPrice()
        {
            return GetLists(itemsPrice);
        }

        #endregion
    }
}
