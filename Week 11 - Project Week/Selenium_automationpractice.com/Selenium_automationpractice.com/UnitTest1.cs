using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_automationpractice.com
{
    public class UnitTest
    {
        [Test]
        public void PasswordTooShort()
        {
            //SeleniumDriver.Manage().Cookies.DeleteAllCookies();
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser to fill the screen
                driver.Manage().Window.Maximize();
                //Navigate to the automationpractice.com homepage
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
                //Wait for the page to Load
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //Enter username
                IWebElement userNameField = driver.FindElement(By.Name("email"));
                userNameField.SendKeys("testing@snailmail.ccm");
                //Enter password
                IWebElement passwordField = driver.FindElement(By.Name("passwd"));
                passwordField.SendKeys("four");
                //click sign in
                IWebElement signInButton = driver.FindElement(By.Id("SubmitLogin"));
                signInButton.Click();
                //check the error is correct for invalid password
                IWebElement passwordError = driver.FindElement(By.Id("center_column"));
                //Assert value is correct
                Assert.That(passwordError.Text, Does.Contain("Invalid password."));
            }
        }

        [Test]
        public void InvalidUsername()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser to fill the screen
                driver.Manage().Window.Maximize();
                //Navigate to the automationpractice.com homepage
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
                //Wait for the page to Load
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //Enter username
                IWebElement userNameField = driver.FindElement(By.Name("email"));
                userNameField.SendKeys("testingsnailmail.ccm");
                //Enter password
                IWebElement passwordField = driver.FindElement(By.Name("passwd"));
                passwordField.SendKeys("four");
                //click sign in
                IWebElement signInButton = driver.FindElement(By.Id("SubmitLogin"));
                signInButton.Click();
                //check the error is correct for invalid password
                IWebElement passwordError = driver.FindElement(By.Id("center_column"));
                //Assert value is correct
                Assert.That(passwordError.Text, Does.Contain("Invalid email address."));
            }
        }

        [Test]
        public void ForgottenPaswordSendToCorrectWebpage_Title()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser to fill the screen
                driver.Manage().Window.Maximize();
                //Navigate to the automationpractice.com homepage
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
                //Wait for the page to Load
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //click forgotten password
                IWebElement passwordError = driver.FindElement(By.CssSelector(".lost_password > a"));
                passwordError.Click();
                //check the error is correct for invalid password
                //Assert value is correct
                Assert.That(driver.Title, Does.Contain("Forgot your password - My Store"));
            }
        }

        [Test]
        public void ForgottenPaswordSendToCorrectWebpage_URL()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser to fill the screen
                driver.Manage().Window.Maximize();
                //Navigate to the automationpractice.com homepage
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
                //Wait for the page to Load
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //click forgotten password
                IWebElement passwordError = driver.FindElement(By.CssSelector(".lost_password > a"));
                passwordError.Click();
                //check the error is correct for invalid password
                //Assert value is correct
                Assert.That(driver.Url, Does.Contain("http://automationpractice.com/index.php?controller=password"));
            }
        }

    }
}
