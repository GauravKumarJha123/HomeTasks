using AventStack.ExtentReports;
using UtilityClassLib.Utilities.Selenium;
using OpenQA.Selenium;
using UtilityClassLib.Report;
using UtilityLibrary.Utilities.PageUtility;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class CartPage : PageUtiltiy
    {
        private InventoryPage inventoryPage = new InventoryPage();
        #region locators
        By itemsPrice => GetXpathUsingDivClass("inventory_item_price");
        By itemsTitle => GetXpathUsingDivClass("inventory_item_name");
        By checkoutBtn => GetByID("checkout");
        #endregion

        #region Elements

        public IList<IWebElement> getItemsTitle()
        {
            return GetLists(itemsTitle);
        }
        public IList<IWebElement> getItemsPrice()
        {
            return GetLists(itemsPrice);
        }
        public void IntiateCheckout()
        {
            ClickWrapper(checkoutBtn);
            //info
        }
        public bool VerifyItemsAreCorrect()
        {
            bool res = true;
            IList<IWebElement> itemsTitleInventoryPage = inventoryPage.getItemsTitle();
            IList<IWebElement> itemsTitleCartPage = getItemsTitle();

            for(int i = 0; i < itemsTitleCartPage.Count; i++)
            {
                if (itemsTitleInventoryPage[i].Text != itemsTitleCartPage[i].Text) res = false;
              
            }

            return res;
        }
        public void VerifyListofProducts()
        {
            ExtentObj.Test = ExtentObj.Report.CreateTest("Cart Test").Info("Cart Test Started");
            ExtentObj.Test.Log(Status.Info, "Logging was Sucess");
            ExtentObj.Test.Log(Status.Info, "Adding Product was Sucess");
            if (VerifyItemsAreCorrect())
            {
                ExtentObj.Test.Log(Status.Pass, ExtentReport.CaptureScreenShot(BasePage.CurrentDriver, "Same Product are in Cart Page"));
            }
            else{
                ExtentObj.Test.Log(Status.Fail, ExtentReport.CaptureScreenShot(BasePage.CurrentDriver, "Same Product was not there in Cart Page"));
            }
        }

        #endregion

    }
}
