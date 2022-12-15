//using AventStack.ExtentReports;
//using CSharpFramework.Utilities;
//using CSharpFramework.Utilities.Selenium;
//using CSharpFrameworkClassLib.Pages.PageObjects;
//using OpenQA.Selenium;

//namespace CSharpFramework.Tests
//{
//    //[Parallelizable(ParallelScope.Children)] --> gor making all methods run parallely .Self for class level

//    public class LoginTest : BaseTest
//    {

//        //[TestCase("standard_user" , "secret_sauce")]
//        [Test, TestCaseSource("TestCaseData")]
//        //[Parallelizable(ParallelScope.All)]
//        public void Test1(string userName, string Pass)
//        {
//            LoginPage loginPage = new LoginPage();
//            loginPage.NavigateBaseUrl();
//            loginPage.EnterUserName(userName);
//            loginPage.UserPass(Pass);
//            loginPage.ClickLoginButton();
//            loginPage.Verify();
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
