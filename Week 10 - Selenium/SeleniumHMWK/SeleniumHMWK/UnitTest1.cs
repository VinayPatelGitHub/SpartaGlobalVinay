using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumHMWK
{
    public class UnitTest1
    {
        [Test]
        public void IncorrectPasswordIncorrectEmailTest()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser to fill the screen
                driver.Manage().Window.Maximize();
                //Navigate to the Facebook homepage
                driver.Navigate().GoToUrl("https://www.instagram.com/?hl=en");
                //Wait for the page to Load
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //Enter username
                IWebElement userNameField = driver.FindElement(By.Name("username"));
                userNameField.SendKeys("vpatel2@spartaglobal.com");
                //Enter password
                IWebElement passwordField = driver.FindElement(By.Name("password"));
                passwordField.SendKeys("WEARESPARTA");
                //click sign in
                IWebElement signInButton = driver.FindElement(By.CssSelector(".Igw0E"));
                signInButton.Click();
                //check the error is correct for invalid password
                IWebElement passwordError = driver.FindElement(By.Id("slfErrorAlert"));
                //Assert value is correct
                Assert.That(passwordError.Text, Does.Contain("The username you entered doesn't belong to an account. Please check your username and try again."));
                //Assert.That(driver.Title, Does.Contain("Log in to Facebook | Facebook"));

            }
        }

        [Test]
        public void IncorrectPasswordCorrectEmailTest()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser to fill the screen
                driver.Manage().Window.Maximize();
                //Navigate to the Facebook homepage
                driver.Navigate().GoToUrl("https://www.instagram.com/?hl=en");
                //Wait for the page to Load
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //Enter username
                IWebElement userNameField = driver.FindElement(By.Name("username"));
                userNameField.SendKeys("Dotlight96");
                //Enter password
                IWebElement passwordField = driver.FindElement(By.Name("password"));
                passwordField.SendKeys("WEARESPARTA");
                //click sign in
                IWebElement signInButton = driver.FindElement(By.CssSelector(".Igw0E"));
                signInButton.Click();
                //check the error is correct for invalid password
                IWebElement passwordError = driver.FindElement(By.Id("slfErrorAlert"));
                //Assert value is correct
                Assert.That(passwordError.Text, Does.Contain("Sorry, your password was incorrect. Please double-check your password."));
                //Assert.That(driver.Title, Does.Contain("Log in to Facebook | Facebook"));

            }
        }
    }
}
