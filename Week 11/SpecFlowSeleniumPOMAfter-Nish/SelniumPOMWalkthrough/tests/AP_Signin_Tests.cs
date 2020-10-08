using System;
using NUnit.Framework;

namespace SelniumPOMWalkthrough
{
	public class AP_Signin_Tests
	{
		public AP_Website AP_Website { get; } = new AP_Website("chrome");


		[Test]
		public void GivenIAmOnTheSignInPage_AndIEnterA4DigitPassword_WhenIClickTheSignInButton_ThenIGetAnErrorMessage()
		{
			AP_Website.AP_SigninPage.VisitSignInPage();
			AP_Website.AP_SigninPage.InputEmail("testing@snailmail.ccm");
			AP_Website.AP_SigninPage.InputPassword("four");
			AP_Website.AP_SigninPage.ClickSignIn();
			Assert.That(AP_Website.AP_SigninPage.GetAlertText(), Does.Contain("Invalid password."));
		}

		[Test]
		public void CheckWhenNavigateToSignInFromHomePage()
		{
			AP_Website.AP_HomePage.VisitHomePage();
			AP_Website.AP_HomePage.ClickSignInLink();

			Assert.That(AP_Website.AP_HomePage.GetLandingPageTitle(), Does.Contain("Login - My Store"));
		}

		[OneTimeTearDown]
		public void CleanUp()
		{
			AP_Website.SeleniumDriver.Quit();
			AP_Website.SeleniumDriver.Dispose();

		}
	}
}
