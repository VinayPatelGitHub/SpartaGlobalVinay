using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough
{
    public class SeleniumDriverConfig
    {
        //propery for the drive for later use
        public IWebDriver Driver {get; set;}

        // constructor that calls a method to set up the driver depending on the browser we want
        public SeleniumDriverConfig(string driver, int pageLoadInSecs, int implicitWaitInSecs)
        {
            DriverSetUp(driver, pageLoadInSecs, implicitWaitInSecs);
        }

        //Driver instantiation manager. This method will trigger another method that sets
        //the driver confinguration depending on the browser type.
        //Note: if none is supplied, an expection will be thrown
        public void DriverSetUp(string driver, int pageLoadInSecs, int implicitWaitInSecs)
        {
            if (driver.ToLower() == "chrome")
            {
                // creates a new driver isntance (chrome) we can use in testing
                SetChromeDriver();
                SetDriverConfiguration(pageLoadInSecs, implicitWaitInSecs);
            }
            else if (driver.ToLower() == "firefox")
            {
                SetFireFoxDriver();
                SetDriverConfiguration(pageLoadInSecs, implicitWaitInSecs);
            }
            else
            {
                throw new Exception("Please use 'chrome' or 'firefox'");
            }
        }

        public void SetChromeDriver()
        {
            Driver = new ChromeDriver();
        }
        public void SetFireFoxDriver()
        {
            Driver = new FirefoxDriver();
        }
        public void SetDriverConfiguration(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);

        }


    }
}
