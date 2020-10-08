using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelniumPOMWalkthrough
{
	public class AP_Website
	{
		public IWebDriver SeleniumDriver { get; internal set; }
		public AP_HomePage AP_HomePage { get; internal set; }
		public AP_SigninPage AP_SigninPage { get; internal set; }

		public AP_Website(string driverName, int pageLoadWaitInSecs = 20, int implcitWaitInSecs = 20)
		{
			SeleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implcitWaitInSecs).Driver;
			AP_HomePage = new AP_HomePage(SeleniumDriver);
			AP_SigninPage = new AP_SigninPage(SeleniumDriver);
		}

		public void DeleteCookies()
		{
			SeleniumDriver.Manage().Cookies.DeleteAllCookies();
		}

	}
}
