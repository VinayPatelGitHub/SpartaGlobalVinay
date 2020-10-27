using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SelniumPOMWalkthrough.BDD
{
    [Binding]
    public class AP_CreateAccountSteps
    {
        public AP_Website AP_Website { get; } = new AP_Website("chrome");

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
        }

        [When(@"I enter the email '(.*)'")]
        public void WhenIEnterTheEmail(string email)
        {
            AP_Website.AP_SigninPage.InputEmailToCreateAccount(email);
        }

        [When(@"Click Create Account")]
        public void WhenClickCreateAccount()
        {
            AP_Website.AP_SigninPage.CreateAccountButtonClick();
        }

        [Then(@"I should see an alert containing the error message ""(.*)""\.")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage_(string error)
        {
            Assert.That(AP_Website.AP_SigninPage.CreateAccountGetAlertText(), Does.Contain(error));
            //AP_Website.AP_SigninPage.PageLandingUrl();
        }

        [Then(@"I should land on the on page which contains with the Url ""(.*)""\.")]
        public void ThenIShouldLandOnTheOnPageWhichContainsWithTheUrl_(string p0)
        {
            Assert.That(AP_Website.AP_SigninPage.PageLandingUrl(), Does.Contain("account-creation"));
        }



        [AfterScenario]
        public void DiposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
