//using AventStack.ExtentReports;
//using CSharpFramework.Utilities;
//using CSharpFramework.Utilities.Selenium;
//using CSharpFrameworkClassLib.Pages.PageObjects;
//using OpenQA.Selenium;
//using UtilityClassLib.Utilities.Selenium;

//namespace CSharpFramework.Tests
//{
//    //[Parallelizable(ParallelScope.Children)] --> gor making all methods run parallely .Self for class level

//    public class LoginTest : BaseTest
//    {

//        //[TestCase("standard_user" , "secret_sauce")]
//        [Test, TestCaseSource("TestCaseData")]
//        [Parallelizable(ParallelScope.All)]
//        public void Test1(string userName, string Pass)
//        {
//            LoginPage loginPage = new LoginPage();
//            loginPage.EnterUserName(userName);
//            loginPage.UserPass(Pass);
            
//            loginPage.ClickLoginButton();
            
//            InventoryPage inventoryPage = new InventoryPage();

//            try
//            {
//                if (!DriverClass.CurrentDriver.Url.Equals(Navigation.inventoryUrl))
//                {
//                    throw new ElementNotVisibleException();
//                }
                
//                inventoryPage.ClickCartButton();
//            }
//            catch(Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            //InventoryPage inventoryPage = loginPage.ClickLoginButton();
//            // transfer to Inventory Page
//            //InventoryPage inventoryPage = loginPage.ClickLoginButton();            

//            //IList<IWebElement> items = inventoryPage.Items();

//            //foreach(IWebElement item in items)
//            //{
//            //    item.Click();
//            //}
//            //IList<IWebElement> itemsTitleInventoryPage = inventoryPage.getItemsTitle();

//            //IList<IWebElement> itemsPriceInventoryPage = inventoryPage.getItemsPrice();

//            //Thread.Sleep(500);

//            // Cart Page
//            //CartPage cartPage = inventoryPage.ClickCheckoutButton();
//            //Thread.Sleep(500);
//            //IList<IWebElement> itemsTitleCartPage = cartPage.getItemsTitle();

//            //IList<IWebElement> itemsPriceCartPage = cartPage.getItemsPrice();

//            //bool verifyItemsTitle = itemsTitleInventoryPage.SequenceEqual(itemsTitleCartPage);
//            //bool verifyItemsPrice = itemsPriceInventoryPage.SequenceEqual(itemsPriceCartPage);
//            //Assert.IsTrue(verifyItemsTitle, "Items Title not Matching");
//            //Assert.IsTrue(verifyItemsPrice, "Items Price not Matching");

//            //Thread.Sleep(500);

//            ////Checkout Page
//            //CheckoutPage checkoutPage = cartPage.IntiateCheckout();
//            //Thread.Sleep(1000);


//            //checkoutPage.FirstName(firstName);
//            //checkoutPage.LastName(lastName);
//            //checkoutPage.ZipCode(zipCode);
//            //checkoutPage.Continue();

//            //IList<IWebElement> itemsTitleCheckoutPage = checkoutPage.getItemsTitle();
//            //IList<IWebElement> itemsPriceCheckoutPage = checkoutPage.getItemsPrice();

//            //bool verifyCheckoutPageItemsTitle = itemsTitleCartPage.SequenceEqual(itemsTitleCheckoutPage);
//            //bool verifyCheckoutPageItemsPrice = itemsPriceCartPage.SequenceEqual(itemsPriceCheckoutPage);
//            //Assert.IsTrue(verifyCheckoutPageItemsTitle, "Items Title not Matching");
//            //Assert.IsTrue(verifyCheckoutPageItemsPrice, "Items Price not Matching");

//            //checkoutPage.Finish();

//            //Thread.Sleep(500);
//        }
//        public static IEnumerable<TestCaseData> TestCaseData()
//        {
//            int i = 0;
//            yield return new TestCaseData(GetDataParser().UserDetails("username").ElementAt(i), GetDataParser().ExtractData("password"));
//            i++;
//            yield return new TestCaseData(GetDataParser().UserDetails("username").ElementAt(i), GetDataParser().ExtractData("password"));
//            i++;
//            yield return new TestCaseData(GetDataParser().UserDetails("username").ElementAt(i), GetDataParser().ExtractData("password"));
//            i++;
//            yield return new TestCaseData(GetDataParser().UserDetails("username").ElementAt(i), GetDataParser().ExtractData("password"));

//        }


//    }
//}
