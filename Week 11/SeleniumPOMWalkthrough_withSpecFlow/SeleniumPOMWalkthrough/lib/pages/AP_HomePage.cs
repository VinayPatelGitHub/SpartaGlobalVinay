using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough
{
    public class AP_HomePage
    {
        //set the driver
        private IWebDriver _driver;
        //setting the homepage URL which will utilise ou AppConfigReader
        private string HomePageUrl = AppConfigReader.BaseUrl;
        private IWebElement _signinLink => _driver.FindElement(By.LinkText("Sign in"));

        public AP_HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitHomePage()
        {
            _driver.Navigate().GoToUrl(HomePageUrl);
        }

        public void ClickSignInLink()
        {
            _signinLink.Click();
        }

    }
}
