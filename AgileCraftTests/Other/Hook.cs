using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TechTalk.SpecFlow;
using AgileCraftTests.Pages;

namespace AgileCraftTests.Other
{
    [Binding]
    class Hook
    {

        [BeforeFeature("setupBrowser")]
        public static void BeforeFeature()
        {
            WebDriverSingleton.getInstance().Manage().Window.Maximize();
        }


        [AfterFeature("quitBrowser")]
        public static void AfterFeature()
        {
            WebDriverSingleton.getInstance().Manage().Cookies.DeleteAllCookies();
            WebDriverSingleton.getInstance().Quit();
        }

        [BeforeScenario("LogIn")]
        public static void LoggingIn()
        {
            LoginPage loginPage = new LoginPage(WebDriverSingleton.getInstance());
            loginPage.InputLogin(Constants.login);
            loginPage.InputPassword(Constants.password);
            loginPage.SignIn();
        }
    }
}
