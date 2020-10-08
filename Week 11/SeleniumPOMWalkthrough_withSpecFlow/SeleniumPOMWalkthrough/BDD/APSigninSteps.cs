using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SeleniumPOMWalkthrough
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
       
        [Given(@"I have entered the incorrect email '(.*)'")]
        public void GivenIHaveEnteredTheIncorrectEmail(string email)
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
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string expected)
        {
            Assert.That(AP_Website.AP_SigninPage.GetAlertText(), Does.Contain(expected));
        }

        //more:

        [When(@"I click the forgot your password\? link")]
        public void WhenIClickTheForgotYourPasswordLink()
        {
            AP_Website.AP_SigninPage.ClickForgottenPasswordButton();
        }

        [Then(@"I will go to a form to reset my password")]
        public void ThenIWillGoToAFormToResetMyPassword()
        {
            Assert.That(AP_Website.AP_SigninPage.ReturnfromClickForgottenPasswordButton, Does.Contain("Please enter the email address you used to register. We will then send you a new password."));
        }

        //more:
        [Then(@"I should see an alert containing the error message ""Invalid email address\.")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessageInvalidEmailAddress_()
        {
            Assert.That(AP_Website.AP_SigninPage.GetAlertText(), Does.Contain("Invalid email address."));

        }

        [Given(@"I have entered the correct email ""(.*)""")]
        public void GivenIHaveEnteredTheCorrectEmail(string email)
        {
            AP_Website.AP_SigninPage.InputEmail(email);        
        }



        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }

    }
}
