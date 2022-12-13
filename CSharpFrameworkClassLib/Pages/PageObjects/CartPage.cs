using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.Utilities.PageUtility;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class CartPage : InventoryPage
    {
       
        
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
        #endregion

    }
}
