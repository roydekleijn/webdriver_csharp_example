using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTesting.Pages
{
	
	public class HomePage
	{
		private IWebDriver driver;
		
		[FindsBy(How = How.CssSelector , Using = "h1#etsy a")]
		public IWebElement homeLink;
		
		[FindsBy(How = How.CssSelector , Using = "a#register")]
		public IWebElement registerLink;
		
		[FindsBy(How = How.CssSelector , Using = "a#sign-in")]
		public IWebElement signinLink;
		
		public HomePage(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver,this);
		}
		
		public void clickRegisterLink() {
			registerLink.Click();
		}

		public SignInPage clickSigninLink() {
			signinLink.Click();
			return new SignInPage(driver);
		}
	}
}
