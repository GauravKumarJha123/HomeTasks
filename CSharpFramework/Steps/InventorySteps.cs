using AventStack.ExtentReports.Gherkin.Model;
using CSharpFramework.Utilities.Selenium;
using CSharpFrameworkClassLib.Pages.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CSharpFramework.Steps
{
    [Binding]
    public class InventorySteps 
    {
        

        private InventoryPage inventoryPage = new InventoryPage();

        //private IList<IWebElement> items = inventoryPage.Items();

        [Given(@"I am Logged in With Valid Credentials")]
        public void GivenIAmLoggedInWithValidCredentials()
        {
            Console.WriteLine(DriverClass.CurrentDriver.Url);
        }
        [Given(@"I Navigated to Inventory Page")]
        public void GivenINavigatedToInventoryPage()
        {
            Console.WriteLine(DriverClass.CurrentDriver.Url);
        }

        [When(@"I Added Items To Cart")]
        public void WhenIAddedItemsToCart()
        {
            inventoryPage.AddItemsToCart();
        }
        [When(@"I Click on Cart Button")]
        public void WhenIClickOnCartButton()
        {
            inventoryPage.ClickCartButton();
        }

        [Then(@"I NAvigate ot Cart Page")]
        public void ThenINAvigateOtCartPage()
        {
            inventoryPage.verifyNavigation();
        }

        [Then(@"Items are added to the cart")]
        public void ThenItemsAreAddedToTheCart()
        {
            Console.WriteLine(DriverClass.CurrentDriver.Url);
        }





    }
}
