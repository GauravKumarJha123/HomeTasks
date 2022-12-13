using AventStack.ExtentReports.Gherkin.Model;
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
        private LoginPage  loginPage = new LoginPage();

        private InventoryPage inventoryPage = null;

        private IList<IWebElement> items;
        //[Given(@"I Logged in With Valid Credentials")]
        //public void GivenILoggedInWithValidCredentials()
        //{
        //    inventoryPage = loginPage.NavigateToInventoryPage();
        //    Thread.Sleep(5000);
        //}
        [Given(@"I Logged in Sucessfully")]
        public void GivenILoggedInSucessfully()
        {
            inventoryPage =  loginPage.NavigateToInventoryPage();
        }

        [When(@"I Added Items to Cart")]
        public void WhenIAddedItemsToCart()
        {
            items = inventoryPage.Items();

        }
        [Then(@"I Add items to Cart")]
        public void ThenIAddItemsToCart()
        {
            items = inventoryPage.Items();
            foreach (var item in items)
            {
                item.Click();
            }
        }
        [Then(@"Item are added to the cart")]
        public void ThenItemAreAddedToTheCart()
        {
            inventoryPage.ClickCartButton();
        }



    }
}
