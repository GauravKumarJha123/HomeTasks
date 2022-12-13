using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary.Utilities.PageUtility;

namespace CSharpFrameworkClassLib.Pages.PageObjects
{
    public class CheckoutPage : CartPage
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
        }
        public void LastName(string lname)
        {
            SendKeysWrapper(lastName, lname);
        }
        public void ZipCode(string code)
        {
            SendKeysWrapper(zipCode, code);

        }
        public void Continue()
        {
            ClickWrapper(continueBtn);
        }
        public void Finish()
        {
            ClickWrapper(finishBtn);
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
