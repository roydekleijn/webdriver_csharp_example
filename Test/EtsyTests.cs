/*
 * Created by SharpDevelop.
 * User: Roy de Kleijn
 * Date: 14-2-2013
 * Time: 22:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium.Support.UI;

using SeleniumTesting.Pages;

namespace SeleniumTesting.Test
{
	
	[TestFixture]
	public class EtsyTests
	{
		public static IWebDriver driver;
		
		[SetUp]
		public void SetUp() {
			driver = new FirefoxDriver();
			driver.Navigate().GoToUrl("http://www.etsy.com");
		}
		
		[TearDown]
		public void tearDown() {
			driver.Close();
		}
		
		[Test]
		public void navigationToRegisterPage()
		{
			HomePage homePage = new HomePage(driver);
			homePage.clickSigninLink();
			homePage.clickRegisterLink();
		}
		
		[Test]
		public void join()
		{
			HomePage homePage = new HomePage(driver);
			homePage.clickSigninLink();
			SignInPage joinPage = new SignInPage(driver);
			joinPage.setUsername("Test");
			joinPage.setPassword("Case");

			HomePage homePage2 = new HomePage(driver);
			homePage.clickSigninLink().setUsername("Test")
				.setPassword("Case").submitForm();

			//Is the same as above
			Factory pages = new Factory(driver);
			pages.homePage().clickSigninLink().setUsername("Test")
				.setPassword("Case").submitForm();
		}
	}
}
