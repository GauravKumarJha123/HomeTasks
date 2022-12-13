//using CSharpFramework.Utilities;
//using CSharpFramework.Utilities.Selenium;
//using CSharpFrameworkClassLib.Pages.PageObjects;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpFramework.Tests
//{
//    public class CheckoutTest : BaseTest
//    {
//        //string? userName;
//        //string? Pass;
//        //string? firstName;
//        //string? lastName;
//        //string? zipCode;

//        [Test, TestCaseSource("TestCaseData")]
//        [Parallelizable(ParallelScope.All)]
//        public void Test4(string userName , string Pass , string firstName , string lastName , string zipCode)
//        {
//            try
//            {
//                LoginPage loginPage = new LoginPage();
//                loginPage.EnterUserName(userName);
//                if (userName == "locked_out_user")
//                {
//                    throw new ElementNotVisibleException();
//                }
//                loginPage.UserPass(Pass);
//                loginPage.ClickLoginButton();
//                InventoryPage inventoryPage = new InventoryPage();

//                IList<IWebElement> items = inventoryPage.Items();

//                foreach (IWebElement item in items)
//                {
//                    item.Click();
//                }
//                IList<IWebElement> itemsTitleInventoryPage = inventoryPage.getItemsTitle();
//                foreach (IWebElement item in itemsTitleInventoryPage)
//                {
//                    Console.Write(item.Text + " ");
//                }
//                Console.WriteLine();
//                IList<IWebElement> itemsPriceInventoryPage = inventoryPage.getItemsPrice();
//                foreach (IWebElement item in itemsPriceInventoryPage)
//                {
//                    Console.Write(item.Text + " ");
//                }
//                inventoryPage.ClickCartButton();

//                CartPage cartPage = new CartPage();
//                Thread.Sleep(500);
//                IList<IWebElement> itemsTitleCartPage = cartPage.getItemsTitle();

//                IList<IWebElement> itemsPriceCartPage = cartPage.getItemsPrice();
                
//                Console.WriteLine();
//                foreach (IWebElement item in itemsTitleCartPage)
//                {
//                    Console.Write(item.Text + " ");
//                }
//                Console.WriteLine();
//                foreach (IWebElement item in itemsPriceCartPage)
//                {
//                    Console.Write(item.Text + " ");
//                }
//                //var result = itemsTitleInventoryPage.Except(itemsTitleCartPage);
//                //var res = Enumerable.SequenceEqual(itemsTitleInventoryPage, itemsTitleCartPage);
//                //bool verifyItemsTitle = itemsTitleInventoryPage.SequenceEqual(itemsTitleCartPage);
//                //bool verifyItemsPrice = itemsPriceInventoryPage.SequenceEqual(itemsPriceCartPage);
//                //Assert.IsTrue(verifyItemsTitle, "Items Title not Matching");
//                //Assert.IsTrue(verifyItemsPrice, "Items Price not Matching");
//                cartPage.IntiateCheckout();
//                //Checkout Page
//                CheckoutPage checkoutPage = new CheckoutPage();
//                Thread.Sleep(1000);

//                checkoutPage.FirstName(firstName);
//                checkoutPage.LastName(lastName);
                
//                checkoutPage.ZipCode(zipCode);
//                checkoutPage.Continue();

//                //IList<IWebElement> itemsTitleCheckoutPage = checkoutPage.getItemsTitle();
//                //IList<IWebElement> itemsPriceCheckoutPage = checkoutPage.getItemsPrice();

//                //bool verifyCheckoutPageItemsTitle = itemsTitleCartPage.SequenceEqual(itemsTitleCheckoutPage);
//                //bool verifyCheckoutPageItemsPrice = itemsPriceCartPage.SequenceEqual(itemsPriceCheckoutPage);
//                //Assert.IsTrue(verifyCheckoutPageItemsTitle, "Items Title not Matching");
//                //Assert.IsTrue(verifyCheckoutPageItemsPrice, "Items Price not Matching");

//                checkoutPage.Finish();
//            }catch(Exception ex) {
//                //Console.WriteLine(ex.ToString());
//                Console.WriteLine(ex.Message);

//            }
//            //ObjectDisposedException
//        }

//        public static IEnumerable<TestCaseData> TestCaseData()
//        {
//            int i = 0;
//            yield return new TestCaseData(GetDataParser().UserDetails("username").ElementAt(i), GetDataParser().ExtractData("password"), GetDataParser().UserDetails("FirstName").ElementAt(i), GetDataParser().UserDetails("LastName").ElementAt(i), GetDataParser().UserDetails("ZipCode").ElementAt(i));
//            i++;
//            yield return new TestCaseData(GetDataParser().UserDetails("username").ElementAt(i), GetDataParser().ExtractData("password"), GetDataParser().UserDetails("FirstName").ElementAt(i), GetDataParser().UserDetails("LastName").ElementAt(i), GetDataParser().UserDetails("ZipCode").ElementAt(i));
//            i++;
//            yield return new TestCaseData(GetDataParser().UserDetails("username").ElementAt(i), GetDataParser().ExtractData("password"), GetDataParser().UserDetails("FirstName").ElementAt(i), GetDataParser().UserDetails("LastName").ElementAt(i), GetDataParser().UserDetails("ZipCode").ElementAt(i));
//            i++;
//            yield return new TestCaseData(GetDataParser().UserDetails("username").ElementAt(i), GetDataParser().ExtractData("password"), GetDataParser().UserDetails("FirstName").ElementAt(i), GetDataParser().UserDetails("LastName").ElementAt(i), GetDataParser().UserDetails("ZipCode").ElementAt(i));

//        }



//    }
//}
