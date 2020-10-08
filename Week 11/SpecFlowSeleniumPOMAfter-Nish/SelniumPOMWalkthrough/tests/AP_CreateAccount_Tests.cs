using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelniumPOMWalkthrough.tests
{
	class AP_CreateAccount_Tests
	{
		public AP_Website AP_Website { get; } = new AP_Website("chrome");

        [Test]
        public void CreatingAccountWith_IncorrectEmailType()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
            AP_Website.AP_SigninPage.ClickCreateEmailField();
            AP_Website.AP_SigninPage.InputEmailToCreateAccount("testing");
            AP_Website.AP_SigninPage.CreateAccountButtonClick();
            Assert.That(AP_Website.AP_SigninPage.CreateAccountGetAlertText(), Does.Contain("Invalid email address."));
        }

        [Test]
        public void CreatingAccountWith_CorrectEmailType()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
            AP_Website.AP_SigninPage.ClickCreateEmailField();
            AP_Website.AP_SigninPage.InputEmailToCreateAccount("testing");
            AP_Website.AP_SigninPage.CreateAccountButtonClick();
            Assert.That(AP_Website.AP_SigninPage.PageLandingTitle(), Does.Contain("Login - My Store"));
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
