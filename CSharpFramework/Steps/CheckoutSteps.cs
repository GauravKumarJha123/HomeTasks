using CSharpFramework.Utilities.Selenium;
using CSharpFrameworkClassLib.Pages.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UtilityClassLib.Utilities.Selenium;

namespace CSharpFramework.Steps
{
    [Binding]
    internal class CheckoutSteps
    {
        private CheckoutPage checkoutPage = new CheckoutPage();

        [Given(@"I Navigate To Cart Page and Click on Checkout Button")]
        public void GivenINavigateToCartPageAndClickOnCheckoutButton()
        {
            Console.WriteLine(DriverClass.CurrentDriver.Url);
        }

        [Given(@"I Enter FirstName as '([^']*)'")]
        public void GivenIEnterFirstNameAs(string firstName)
        {
            checkoutPage.FirstName(firstName);
        }

        [Given(@"I Enter LastName as '([^']*)'")]
        public void GivenIEnterLastNameAs(string lastName)
        {
            checkoutPage.LastName(lastName);
        }

        [Given(@"I Enter ZipCode as '([^']*)'")]
        public void GivenIEnterZipCodeAs(string zipCode)
        {
            checkoutPage.ZipCode(zipCode);
        }


        [Given(@"I Click on Continue Button")]
        public void GivenIClickOnContinueButton()
        {
            checkoutPage.ContinueButton();
        }

        [Then(@"Checkout is Intiated")]
        public void ThenCheckoutIsIntiated()
        {
            Assert.IsTrue(DriverClass.CurrentDriver.Url.Equals(Navigation.checkoutUrl),
                "We are not on Checkout Page");

        }

        [When(@"I Click on Finish Button")]
        public void WhenIClickOnFinishButton()
        {
            checkoutPage.FinishButton();
        }

        [Then(@"Checkout Process is completed")]
        public void ThenCheckoutProcessIsCompleted()
        {
            checkoutPage.VerifyFinishPage();
            //Assert.IsTrue(DriverClass.CurrentDriver.Url.Equals(Navigation.finshPageUrl),
            //       "We are not on Finish Page");
        }


    }
}
