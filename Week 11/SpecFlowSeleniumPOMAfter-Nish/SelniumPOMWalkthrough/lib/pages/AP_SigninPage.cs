using OpenQA.Selenium;
using System;
using System.Threading;

namespace SelniumPOMWalkthrough
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
		private IWebElement _createAccountAlert => _driver.FindElement(By.Id("create_account_error"));
		private IWebElement _createAccountButton => _driver.FindElement(By.Id("SubmitCreate"));
		private IWebElement _createAccountFormField => _driver.FindElement(By.Name("email_create"));


		public AP_SigninPage(IWebDriver driver)
		{
			_driver = driver;
		}
		
		public void VisitSignInPage()
		{
			_driver.Navigate().GoToUrl(_signInPageURL);
		}

		public void InputEmail(string email)
		{
			_emailField.SendKeys(email);
		}
		public void ClickPasswordField()
		{
			_passwordField.Click();
		}

		public void InputPassword(string password)
		{
			_passwordField.SendKeys(password);
		}

		public string GetAlertText()
		{
			return _alert.Text;
		}

		public void ClickSignIn()
		{
			_signinButton.Click();
		}

		public void ClickCreateEmailField()
		{
			_createAccountFormField.Click();

		}

		public void ClickForgotPassword()
		{
			_forgotPasswordLink.Click();
		}

		public void InputEmailToCreateAccount(string email)
		{
			_createAccountFormField.SendKeys(email);
		}
		public void CreateAccountButtonClick()
		{
			_createAccountButton.Click();
		}

		public string CreateAccountGetAlertText()
		{
			Thread.Sleep(2000);
			return _createAccountAlert.Text;
		}

		public string PageLandingTitle()
		{
			
			return _driver.Title;
		}

		public string PageLandingUrl()
		{
			Thread.Sleep(5000);

			return _driver.Url;
		}

	}
}
