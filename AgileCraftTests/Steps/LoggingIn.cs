using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileCraftTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AgileCraftTests.Steps
{
    [Binding]
    class LoggingIn
    {
        IWebDriver driver = WebDriverSingleton.getInstance();

        [Given(@"I have opened the AgileCraft web-site")]
        public void GivenIHaveOpenedTheAgileCraftWeb_Site()
        {
            driver.Navigate().GoToUrl("https://goldendb.agilecraft.xyz/login");
        }

        [When(@"I have logined in with proper credentials")]
        public void WhenIHaveLoginedInWithProperCredentials()
        {
            LoginPage loginPage = new LoginPage(WebDriverSingleton.getInstance());
            loginPage.InputLogin(Constants.login);
            loginPage.InputPassword(Constants.password);
            loginPage.SignIn();
        }

        [Then(@"the Home Page is opened")]
        public void ThenTheHomePageIsOpened()
        {
            HomePage homePage = new HomePage();
            Assert.IsTrue(homePage.isLogoDisplayed());
        }

    }
}
