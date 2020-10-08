using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelniumPOMWalkthrough
{
	public class AP_HomePage
	{
		//set the driver 
		private IWebDriver _driver;
		//setting the homepageUrl which will utilise our AppConfigReader
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

		public string GetLandingPageTitle()
		{
			return _driver.Title;
		}

	}
}
