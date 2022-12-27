using AventStack.ExtentReports;
using UtilityClassLib.Utilities.Selenium;
using OpenQA.Selenium;
using UtilityLibrary.Utilities.PageUtility;
using UtilityClassLib.Report;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class InventoryPage : PageUtiltiy
    {
        
        #region locators
        private By items => By.XPath("//button[@class='btn btn_primary btn_small btn_inventory']");
        private By itemsTitle => GetXpathUsingDivClass("inventory_item_name");
        private By itemsPrice => GetXpathUsingDivClass("inventory_item_price");
        private By cartBtn => GetByID("shopping_cart_container");
        #endregion

        #region Actions
        public IList<IWebElement> Items()
        {
            ExtentObj.Test = ExtentObj.Report.CreateTest("InventoryTest").Info("Inventory Test Started");
            ExtentObj.Test.Log(Status.Info, "Logging was Sucess");
            ExtentObj.Test.Log(Status.Info, "Products are Visible");
            return GetLists(items);
        }

        public IList<IWebElement> getItemsTitle()
        {
            ExtentObj.Test.Log(Status.Info, "Products titles are Visible");
            return GetLists(itemsTitle);
        }

        public IList<IWebElement> getItemsPrice()
        {
            ExtentObj.Test.Log(Status.Info, "Products Prices are Visible");
            return GetLists(itemsPrice);
        }
      
        public void AddItemsToCart()
        {
            IList<IWebElement> products = Items();
            foreach(var product in products)
            {
                product.Click();
            }
            ExtentObj.Test.Log(Status.Info, "Items are Added To Cart");
        }

        public void ClickCartButton()
        {
            ClickWrapper(cartBtn);
            ExtentObj.Test.Log(Status.Info, "Cart Button is Clicked");
        }

        public void verifyNavigation()
        {
            if (BasePage.CurrentDriver.Url.Equals(Navigation.cartPageUrl))
            {
                ExtentObj.Test.Log(Status.Pass, ExtentReport.CaptureScreenShot(BasePage.CurrentDriver, "pass"));
            }
            else
            {
                ExtentObj.Test.Log(Status.Fail, ExtentReport.CaptureScreenShot(BasePage.CurrentDriver, "fail"));
            }
        }
        public By ByItemsElements()
        {
            return items;
        }
        public By ByPriceElements()
        {
            return itemsPrice;
        }
       
        #endregion

    }
}
