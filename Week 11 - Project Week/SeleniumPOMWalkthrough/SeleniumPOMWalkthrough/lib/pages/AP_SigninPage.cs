using OpenQA.Selenium;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;

namespace SeleniumPOMWalkthrough
{
    public class AP_SigninPage
    {
        private IWebDriver _driver;
        private string _signInPageURL = AppConfigReader.SignInPageUrl;      
        private IWebElement _emailField => _driver.FindElement(By.Id("email"));
        private IWebElement _passwordField => _driver.FindElement(By.Id("passwd"));
        private IWebElement _signinButton => _driver.FindElement(By.Id("SubmitLogin"));
        private IWebElement _forgotPasswordLink => _driver.FindElement(By.LinkText("Forgot your password?"));
        private IWebElement _alert => _driver.FindElement(By.ClassName("alert"));
        //for create:
        private IWebElement _emailCreateAccountField => _driver.FindElement(By.Id("email_create"));
        //private IWebElement _createAccoutAlert => _driver.FindElement(By.CssSelector("ol > li"));   
        private IWebElement _createAccoutAlert => _driver.FindElement(By.Id("create_account_error"));
        private IWebElement _createAccountButton => _driver.FindElement(By.Id("SubmitCreate"));
        private IWebElement _createAccountDetails => _driver.FindElement(By.Id("account-creation_form"));
        // for forgotten password:
        private IWebElement _forgottenPasswordForm => _driver.FindElement(By.Id("center_column"));


        public AP_SigninPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal void ClickForgottenPasswordButton()
        {
            _forgotPasswordLink.Click();
        }
        internal string ReturnfromClickForgottenPasswordButton()
        {
            return _forgottenPasswordForm.Text; 
        }

        internal void InputEmailToCreateAccount(string email)
        {
            _emailCreateAccountField.SendKeys(email);
        }

        internal void ClickCreateAccountButton()
        {
            _createAccountButton.Click();
        }

        internal string CreateAccountGetAlertText()
        {
            Thread.Sleep(3000);
            return _createAccoutAlert.Text;
        }

        internal string CreateAccountGetURL()
        {
            Thread.Sleep(5000);
            return _createAccountDetails.Text;
        }

        internal void VisitSignInPage()
        {
            _driver.Navigate().GoToUrl(_signInPageURL);
        }

        internal void InputEmail(string email)
        {
            _emailField.SendKeys(email);
        }

        internal void ClickPasswordField()
        {
            _passwordField.Click();
        }

        internal void InputPassword(string password)
        {
            _passwordField.SendKeys(password);
        }

        internal string GetAlertText()
        {
            return _alert.Text;
        }

        internal void ClickSignIn()
        {
            _signinButton.Click();
        }
    }
}
