using TechTalk.SpecFlow;
using UtilityClassLib.Utilities;
using CSharpFrameworkClassLib.Pages.PageObjects;
using OpenQA.Selenium;
using Allure.Commons;
using WebDriverManager;
using UtilityClassLib.Utilities.Selenium;

namespace UtilityClassLib.Hooks
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

        [BeforeScenario("Inventory")]
        [BeforeScenario("Cart")]
        [BeforeScenario("Checkout")]
        public void LoginHooks()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.NavigateBaseUrl();
            loginPage.EnterUserName("standard_user");
            loginPage.UserPassword("secret_sauce");
            loginPage.ClickLoginButton();
            loginPage.VerifyNavigationToInventoryPage();

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
            CartPage cartPage = new CartPage();
            cartPage.VerifyListofProducts();
            cartPage.IntiateCheckout();
        }

        //[AfterScenario]
        //public void StopWebDriver()
        //{
        //    EndTest();
        //}

        [AfterScenario]
        public void AfterStep()
        {
            byte[] content = CaptureScreenshotAllure();
            AllureLifecycle.Instance.AddAttachment("Test", "application/png", content);
            EndTest();
        }

        public static byte[] CaptureScreenshotAllure()
        {
            return ((ITakesScreenshot)BasePage.CurrentDriver).GetScreenshot().AsByteArray;
        }

    }
}
