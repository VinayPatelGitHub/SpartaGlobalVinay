using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough
{
    public class AP_Website
    {
        public IWebDriver SeleniumDriver { get; internal set; }
        public AP_HomePage AP_HomePage { get; internal set; }
        public AP_SigninPage AP_SigninPage { get; internal set; }

        public AP_Website(string driver, int pageLoadInSecs = 10, int implicitWaitInSecs = 10)
        {
            SeleniumDriver = new SeleniumDriverConfig(driver, pageLoadInSecs, implicitWaitInSecs).Driver;
            AP_HomePage = new AP_HomePage(SeleniumDriver);
            AP_SigninPage = new AP_SigninPage(SeleniumDriver);
        }

        public void DeleteCookies()
        {
            SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        }

    }
}
