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
//    public class CartTest : BaseTest
//    {

//        [Test, TestCaseSource("TestCaseData")]
//        [Parallelizable(ParallelScope.All)]
//        public void Test3(string userName, string Pass)
//        {

//                LoginPage loginPage = new LoginPage();
//                loginPage.EnterUserName(userName);
//                loginPage.UserPass(Pass);
//                loginPage.ClickLoginButton();
//                if (userName == "locked_out_user")
//                {
//                    throw new ElementNotVisibleException();
//                }
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
//                //Assert.IsTrue(res, "Items Title not Matching");
//                //Assert.IsTrue(verifyItemsPrice, "Items Price not Matching");
//                cartPage.IntiateCheckout();
//                //IList<IWebElement> itemsTitleCartPage = cartPage.getItemsTitle();

//                //IList<IWebElement> itemsPriceCartPage = cartPage.getItemsPrice();

//                //bool verifyItemsTitle = itemsTitleInventoryPage.SequenceEqual(itemsTitleCartPage);
//                //bool verifyItemsPrice = itemsPriceInventoryPage.SequenceEqual(itemsPriceCartPage);
//                //Assert.IsTrue(verifyItemsTitle, "Items Title not Matching");
//                //Assert.IsTrue(verifyItemsPrice, "Items Price not Matching");

//                //Thread.Sleep(500);
//                //EndTest();

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
