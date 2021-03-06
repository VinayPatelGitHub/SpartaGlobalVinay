﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SelniumPOMWalkthrough
{
	public class SeleniumDriverConfig
	{
		//property for the driver for later use
		public IWebDriver Driver { get; set;}

		//contuctortor that calls a method to set up the driver depending on the browser we want
		public SeleniumDriverConfig(string driver, int pageLoadInSecs, int implicitWaitInSecs)
		{
			DriverSetUp(driver, pageLoadInSecs, implicitWaitInSecs);
		}

		//Drive instatantiation manager. This method will trigger another method that sets
		//the driver configuration depending on the browswer type. 
		//Note: if none is supplied, an exception will be thrown
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

		public void SetFireFoxDriver()
		{
			Driver = new FirefoxDriver();
		}

		public void SetChromeDriver()
		{
			Driver = new ChromeDriver();
		}

		public void SetDriverConfiguration(int pageLoadInSecs, int implicitWaitInSecs)
		{
			Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);

		}
	}
}
