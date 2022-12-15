using AventStack.ExtentReports;
using CSharpFramework.Utilities.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.Utilities.PageUtility;
using UtilityClassLib.Utilities.Selenium;
using UtilityClassLib.Report;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class InventoryPage : PageUtiltiy
    {
        
        
        #region locators
        private By items => By.XPath("//button[@class='btn btn_primary btn_small btn_inventory']");

        private By itemsTitle => By.XPath("//div[@class='inventory_item_name']");

        private By itemsPrice => By.XPath("//div[@class='inventory_item_price']");

        private By cartBtn => By.XPath("//div[@id='shopping_cart_container']");


        #region Elements

        public IList<IWebElement> Items()
        {
            extentReport.test = extentReport.report.CreateTest("InventoryTest").Info("Inventory Test Started");
            extentReport.test.Log(Status.Info, "Logging was Sucess");
            extentReport.test.Log(Status.Info, "Products are Visible");
            return GetLists(items);
        }

        public IList<IWebElement> getItemsTitle()
        {
            extentReport.test.Log(Status.Info, "Products titles are Visible");
            return GetLists(itemsTitle);
        }

        public IList<IWebElement> getItemsPrice()
        {
            extentReport.test.Log(Status.Info, "Products Prices are Visible");
            return GetLists(itemsPrice);

        }

      
        public void AddItemsToCart()
        {
            IList<IWebElement> products = Items();
            foreach(var product in products)
            {
                product.Click();
            }
            extentReport.test.Log(Status.Info, "Items are Added To Cart");
        }

        public void ClickCartButton()
        {
            ClickWrapper(cartBtn);
            extentReport.test.Log(Status.Info, "Cart Button is Clicked");
            
        }


        public void verifyNavigation()
        {
            if (DriverClass.CurrentDriver.Url.Equals(Navigation.cartPageUrl))
            {
                extentReport.test.Log(Status.Pass, ExtentReport.captureScreenShot(DriverClass.CurrentDriver, "pass"));
            }
            else
            {
                extentReport.test.Log(Status.Fail, ExtentReport.captureScreenShot(DriverClass.CurrentDriver, "fail"));
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
        //public IList<IWebElement> getItemsTitle()
        //{
        //    return itemsTitle;
        //}
        //public IList<IWebElement> getItemsPrice()
        //{
        //    return itemsPrice;
        //}

        //public CartPage ClickCheckoutButton()
        //{
        //     cartBtn.Click();
        //     return new CartPage(driver);
        //}
        #endregion

        //public IWebElement webElementitem1()
        //{
        //    return item1;
        //}

        //public void WaitForPageDisplay()
        //{
        //    WebDriver wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        //    wait
        //}
        #endregion

    }
}
