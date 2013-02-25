using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTesting.Pages
{
	public class SignInPage
	{
		private IWebDriver driver;
		
		[FindsBy(How = How.CssSelector , Using = "input#username-existing")]
		public IWebElement usernameTextfield;
		
		[FindsBy(How = How.CssSelector , Using = "input#password-existing")]
		public IWebElement passwordTextfield;
		
		[FindsBy(How = How.CssSelector , Using = "span#signin-button input")]
		public IWebElement signInButton;
		
		
		public SignInPage(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver,this);
		}
		
		public SignInPage setUsername(String username) {
			usernameTextfield.SendKeys(username);
			return this;
		}

		public SignInPage setPassword(String password) {
			passwordTextfield.SendKeys(password);
			return this;
		}

		public SignInPage submitForm() {
			signInButton.Click();
			return this;
		}
	}
}
