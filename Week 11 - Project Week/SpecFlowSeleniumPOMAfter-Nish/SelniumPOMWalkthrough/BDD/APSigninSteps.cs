using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SelniumPOMWalkthrough.BDD
{
    [Binding]
    public class APSigninSteps
    {
        public AP_Website AP_Website { get; } = new AP_Website("chrome");

        [Given(@"I am on the signin page")]
        public void GivenIAmOnTheSigninPage()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
        }
        
        [Given(@"I have entered the email ""(.*)""")]
        public void GivenIHaveEnteredTheEmail(string email)
        {


            AP_Website.AP_SigninPage.InputEmail(email);

        }
        
        [Given(@"I have entered the password (.*)")]
        public void GivenIHaveEnteredThePassword(string password)
        {

            AP_Website.AP_SigninPage.InputPassword(password);

        }
        
        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            AP_Website.AP_SigninPage.ClickSignIn();
        }
        
        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string p0)
        {
            Assert.That(AP_Website.AP_SigninPage.GetAlertText(), Does.Contain("Invalid password."));
        }



        [Then(@"I should see an alert containing the error message ""Invalid email address\.”")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessageInvalidEmailAddress_()
        {
            Assert.That(AP_Website.AP_SigninPage.GetAlertText(), Does.Contain("Invalid email address"));
        }

        [When(@"I click the forgot your password\? link")]
        public void WhenIClickTheForgotYourPasswordLink()
        {
            AP_Website.AP_SigninPage.ClickForgotPassword();
        }

        [Then(@"I will go to a form to reset my password")]
        public void ThenIWillGoToAFormToResetMyPassword()
        {
            Assert.That(AP_Website.SeleniumDriver.Title, Is.EqualTo("Forgot your password - My Store"));
        }


        [AfterScenario]
        public void DiposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
