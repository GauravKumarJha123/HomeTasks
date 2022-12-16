using AventStack.ExtentReports;
using UtilityClassLib.Utilities.Selenium;
using OpenQA.Selenium;
using UtilityClassLib.Report;
using UtilityLibrary.Utilities.PageUtility;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class CheckoutPage : PageUtiltiy
    {
        #region Locators
        By ItemsTitle => GetXpathUsingDivClass("inventory_item_name");
        By ItemsPrice => GetXpathUsingDivClass("inventory_item_price");
        By FirstName => GetByID("first-name");
        By LastName => GetByID("last-name");
        By ZipCode => GetByID("postal-code");
        By ContinueBtn => GetByID("continue");
        By FinishBtn => GetByID("finish");
        #endregion

        #region locators
        public void EnterFirstName(string user)
        {
            SendKeysWrapper(FirstName, user);
            ExtentObj.Test = ExtentObj.Report.CreateTest("Checkout Test").Info("Checkout Test Started");
            ExtentObj.Test.Log(Status.Info, "Logging was Sucess");
            ExtentObj.Test.Log(Status.Info, "Adding Product was Sucess");
            ExtentObj.Test.Log(Status.Info, "Navigated To Checkout Page");
            ExtentObj.Test.Log(Status.Info, "First Name is entered");
        }
        public void EnterLastName(string lname)
        {
            SendKeysWrapper(LastName, lname);
            ExtentObj.Test.Log(Status.Info, "Last Name is entered");
        }
        public void EnterZipCode(string code)
        {
            SendKeysWrapper(ZipCode, code);
            ExtentObj.Test.Log(Status.Info, "ZipCode Name is entered");
        }
        public void ContinueButton()
        {
            ClickWrapper(ContinueBtn);
            ExtentObj.Test.Log(Status.Info, "Continue Button is CLicked");

        }
        public void FinishButton()
        {
            ClickWrapper(FinishBtn);
            ExtentObj.Test.Log(Status.Info, "Finish Button is CLicked");
            
        }

        public void VerifyFinishPage()
        {
            if (BasePage.CurrentDriver.Url.Equals(Navigation.finshPageUrl))
            {
                if (ExtentObj.Test.Status == Status.Pass)
                {
                    ExtentObj.Test.Log(Status.Pass, ExtentReport.CaptureScreenShot(BasePage.CurrentDriver, "Checkout Test Passed"));
                }
                else
                {
                    ExtentObj.Test.Log(Status.Fail, ExtentReport.CaptureScreenShot(BasePage.CurrentDriver, "Checkout Failed"));
                }
            }
            else
            {
                ExtentObj.Test.Log(Status.Fail, ExtentReport.CaptureScreenShot(BasePage.CurrentDriver, "Checkout Failed"));
            }
        }
        #endregion


        #region Methods
        public IList<IWebElement> getItemsTitle()
        {
            return GetLists(ItemsTitle);
        }
        public IList<IWebElement> getItemsPrice()
        {
            return GetLists(ItemsPrice);
        }

        #endregion
    }
}
