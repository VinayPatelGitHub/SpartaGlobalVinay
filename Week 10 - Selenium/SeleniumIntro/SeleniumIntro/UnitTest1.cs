using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumIntro
{
    public class FacebookTests
    {
        [Test]
        public void IncorrectPasswordIncorrectEmailTest()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser to fill the screen
                driver.Manage().Window.Maximize();
                //Navigate to the Facebook homepage
                driver.Navigate().GoToUrl("https://www.facebook.com");
                //Wait for the page to Load
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //Enter username
                IWebElement userNameField = driver.FindElement(By.Id("email"));
                userNameField.SendKeys("vpatel2@spartaglobal.com");
                //Enter password
                IWebElement passwordField = driver.FindElement(By.Id("pass"));
                passwordField.SendKeys("WEARESPARTA");
                //click sign in
                IWebElement signInButton = driver.FindElement(By.Name("login"));
                signInButton.Click();
                //check the error is correct for invalid password
                IWebElement passwordError = driver.FindElement(By.Id("login_form"));
                //Assert value is correct
                //Assert.That(passwordError.Text, Does.Contain("The email address that you've entered doesn't match any account."));
                Assert.That(driver.Title, Does.Contain("Log in to Facebook | Facebook"));

            }
        }
    }
}
