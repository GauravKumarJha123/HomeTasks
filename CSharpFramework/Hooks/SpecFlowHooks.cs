using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UtilityLibrary.Utilities.PageUtility;
using CSharpFramework.Utilities.Selenium;
using CSharpFramework.Utilities;
using CSharpFrameworkClassLib.Pages.PageObjects;

namespace CSharpFramework.Hooks
{
    //private BasePage basePage = new BasePage();

    [Binding]
    public sealed class SpecFlowHooks : BaseTest
    {

        
        [BeforeScenario]
        //[Scope(Tag = "Chrome")]
        public void StartChromeDriver()
        {
            Setup();
        }

        [BeforeScenario]
        [Scope(Tag = "Inventory")]
        [Scope(Tag = "Cart")]
        [Scope(Tag = "Checkout")]
        public void LoginHooks()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.NavigateBaseUrl();
            loginPage.EnterUserName("standard_user");
            loginPage.UserPass("secret_sauce");
            loginPage.ClickLoginButton();
            loginPage.Verify();

        }
        [BeforeScenario("Checkout")]
        [BeforeScenario("Cart")]

        public void InventoryHooks()
        {
            InventoryPage inventoryPage = new InventoryPage();
            inventoryPage.AddItemsToCart();
            inventoryPage.ClickCartButton();
            inventoryPage.verifyNavigation();
        }
        [BeforeScenario("Checkout")]
        public void CartHooks()
        {
            //InventoryPage inventoryPage = new InventoryPage();
            //inventoryPage.ClickCartButton();
            CartPage cartPage = new CartPage();
            cartPage.VerifyListofProducts();
            cartPage.IntiateCheckout();
        }
        //[Before]
        //[Scope(Tag = "Firefox")]
        //internal static void StartFirefoxDriver()
        //{
        //    DriverClass.Init("Firefox");

        //}

        [AfterScenario]
        public void StopWebDriver()
        {
            EndTest();
        }
    }
}
