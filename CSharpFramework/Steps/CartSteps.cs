using UtilityClassLib.Utilities.Selenium;
using CSharpFrameworkClassLib.Pages.PageObjects;
using TechTalk.SpecFlow;

namespace UtilityClassLib.Steps
{
    [Binding]
    public class CartSteps
    {
        private CartPage cartPage = new CartPage();
        [Given(@"I am logged in Sucessfully")]
        public void GivenIAmLoggedInSucessfully()
        {
            Console.WriteLine(BasePage.CurrentDriver.Url);
        }

        [Given(@"I have Added Items To Cart")]
        public void GivenIHaveAddedItemsToCart()
        {
            Console.WriteLine(BasePage.CurrentDriver.Url);
            //inventoryPage.AddItemsToCart();
        }



        [When(@"I Navigate To Cart Page")]
        public void WhenINavigateToCartPage()
        {
            Console.WriteLine(BasePage.CurrentDriver.Url);
        }

        [Then(@"I See My List Of Products")]
        public void ThenISeeMyListOfProducts()
        {
            cartPage.VerifyListofProducts();
        }

    }
}
