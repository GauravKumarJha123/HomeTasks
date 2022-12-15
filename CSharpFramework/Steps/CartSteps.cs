using CSharpFramework.Utilities.Selenium;
using CSharpFrameworkClassLib.Pages.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CSharpFramework.Steps
{
    [Binding]
    public class CartSteps
    {
        private CartPage cartPage = new CartPage();
        [Given(@"I am logged in Sucessfully")]
        public void GivenIAmLoggedInSucessfully()
        {
            Console.WriteLine(DriverClass.CurrentDriver.Url);
        }

        [Given(@"I have Added Items To Cart")]
        public void GivenIHaveAddedItemsToCart()
        {
            Console.WriteLine(DriverClass.CurrentDriver.Url);
            //inventoryPage.AddItemsToCart();
        }



        [When(@"I Navigate To Cart Page")]
        public void WhenINavigateToCartPage()
        {
            Console.WriteLine(DriverClass.CurrentDriver.Url);
        }

        [Then(@"I See My List Of Products")]
        public void ThenISeeMyListOfProducts()
        {
            cartPage.VerifyListofProducts();
        }

    }
}
