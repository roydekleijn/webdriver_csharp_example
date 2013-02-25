using System;
using OpenQA.Selenium;

namespace SeleniumTesting.Pages
{
	public class Factory
	{
		private IWebDriver driver;
		
		public Factory(IWebDriver driver)
		{
			this.driver = driver;
		}
		
		public HomePage homePage() {
			return new HomePage(driver);
		}

		public SignInPage signInPage() {
			return new SignInPage(driver);
		}
		
	}
}
