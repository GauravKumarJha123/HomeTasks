using CSharpFramework.Utilities.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.Utilities.PageUtility;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class InventoryPage : LoginPage
    {
        IWebDriver driver = DriverClass.CurrentDriver;
        public InventoryPage()
        {
                
        }

        public InventoryPage(IWebDriver driver)
        {
                this.driver= driver;
        }
        #region locators
        private By items => By.XPath("//button[@class='btn btn_primary btn_small btn_inventory']");

        private By itemsTitle => By.XPath("//div[@class='inventory_item_name']");

        private By itemsPrice => By.XPath("//div[@class='inventory_item_price']");

        private By cartBtn => By.XPath("//div[@id='shopping_cart_container']");


        #region Elements

        public IList<IWebElement> Items()
        {
            return GetLists(items);
        }

        public IList<IWebElement> getItemsTitle()
        {
            return GetLists(itemsTitle);
        }

        public IList<IWebElement> getItemsPrice()
        {
            return GetLists(itemsPrice);
        }

        public void ClickCartButton()
        {
            ClickWrapper(cartBtn);
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
