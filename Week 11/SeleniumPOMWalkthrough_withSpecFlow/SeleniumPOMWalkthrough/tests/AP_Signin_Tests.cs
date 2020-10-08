//using System;
//using NUnit.Framework;

//namespace SeleniumPOMWalkthrough
//{
    //public class AP_Signin_Tests
    //{
        //public AP_Website AP_Website { get; } = new AP_Website("chrome");
        

        //[Test]
        //public void CreateAccountWith_IncorrectEmailType()
        //{
        //    AP_Website.AP_SigninPage.VisitSignInPage();
        //    AP_Website.AP_SigninPage.InputEmailToCreateAccount("testingsnailmail.ccm");
        //    AP_Website.AP_SigninPage.ClickCreateAccountButton();
        //    Assert.That(AP_Website.AP_SigninPage.CreateAccountGetAlertText(), Does.Contain("Invalid email address."));
        //}

        //[Test]
        //public void CreateAccountWith_CorrectEmailType()
        //{
        //    AP_Website.AP_SigninPage.VisitSignInPage();
        //    AP_Website.AP_SigninPage.InputEmailToCreateAccount("testing@snailmail.ccm");
        //    AP_Website.AP_SigninPage.ClickCreateAccountButton();
        //    Assert.That(AP_Website.AP_SigninPage.CreateAccountGetURL, Does.Contain("YOUR PERSONAL INFORMATION"));
        //}

        //[Test]
        //public void Signin_badpassword()
        //{
        //    AP_Website.AP_SigninPage.VisitSignInPage();
        //    AP_Website.AP_SigninPage.InputEmail("testing@snailmail.ccm");
        //    AP_Website.AP_SigninPage.InputPassword("four");
        //    AP_Website.AP_SigninPage.ClickSignIn();
        //    Assert.That(AP_Website.AP_SigninPage.GetAlertText(), Does.Contain("Invalid password."));
        //}
        //[Test]
        //public void Signin_badusernameAndbadpassword()
        //{
        //    AP_Website.AP_SigninPage.VisitSignInPage();
        //    AP_Website.AP_SigninPage.InputEmail("testingsnailmail.ccm");
        //    AP_Website.AP_SigninPage.InputPassword("four");
        //    AP_Website.AP_SigninPage.ClickSignIn();
        //    Assert.That(AP_Website.AP_SigninPage.GetAlertText(), Does.Contain("Invalid email address."));
        //}
        //[Test]
        //public void ForgottenPasswordButton()
        //{
        //    AP_Website.AP_SigninPage.VisitSignInPage();
        //    AP_Website.AP_SigninPage.ClickForgottenPasswordButton();
        //    Assert.That(AP_Website.AP_SigninPage.ReturnfromClickForgottenPasswordButton, Does.Contain("Please enter the email address you used to register. We will then send you a new password."));
        //}      

        //[OneTimeTearDown]
        //public void CleanUp()
        //{
        //    AP_Website.SeleniumDriver.Quit();
        //    AP_Website.SeleniumDriver.Dispose();
        //}

    //}
//}
