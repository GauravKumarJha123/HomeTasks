using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.Utilities.PageUtility;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class CartPage : PageUtiltiy
    {
       
        private InventoryPage inventoryPage = new InventoryPage();
        #region locators

        By itemsPrice => By.XPath("//div[@class='inventory_item_price']");

        By itemsTitle => By.XPath("//div[@class='inventory_item_name']");

        By checkoutBtn => By.XPath("//button[@id='checkout']");
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
            extentReport.test = extentReport.report.CreateTest("Cart Test").Info("Cart Test Started");
            extentReport.test.Log(Status.Info, "Logging was Sucess");
            extentReport.test.Log(Status.Info, "Adding Product was Sucess");
            if (VerifyItemsAreCorrect())
            {
                extentReport.test.Log(Status.Pass, "Same Product are in Cart Page");
                
            }
            else extentReport.test.Log(Status.Fail, "Same Product was not there in Cart Page");

        }

        //public void TestPassed()
        //{
        //    if (extentReport.test.Status == Status.Pass)
        //        extentReport.test.Log(Status.Pass, "Cart Test Passed");
        //    else
        //        extentReport.test.Log(Status.Fail, "Cart Test Failed");
        //}
        #endregion

    }
}
