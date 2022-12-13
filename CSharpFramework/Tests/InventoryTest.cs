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
//    public class InventoryTest : BaseTest
//    {
//        [Test, TestCaseSource("TestCaseData")]
//        [Parallelizable(ParallelScope.All)]
//        public void Test2(string userName, string Pass)
//        {
//            try
//            {
//                //LoginTest lt = new LoginTest();
//                //lt.Flow(userName, Pass);
//                LoginPage loginPage = new LoginPage();
//                loginPage.EnterUserName(userName);
//                if(userName == "locked_out_user")
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
//                    Console.Write(item.Text);
//                }
//                Console.WriteLine();
//                IList<IWebElement> itemsPriceInventoryPage = inventoryPage.getItemsPrice();
//                foreach (IWebElement item in itemsPriceInventoryPage)
//                {
//                    Console.Write(item.Text);
//                }
//                inventoryPage.ClickCartButton();
//            }
//            catch(Exception ex) { 
//                Console.WriteLine(ex.Message);
//            }

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
