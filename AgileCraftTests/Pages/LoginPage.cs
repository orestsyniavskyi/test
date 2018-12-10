using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AgileCraftTests.Pages
{
    class LoginPage
    {
        protected IWebElement LoginInput { get; set; }
        protected IWebElement PasswordInput { get; set; }
        protected IWebElement SignInButton { get; set; }
        protected IWebElement ForgotYourPassword { get; set; }

        public LoginPage(IWebDriver driver)
        {
            LoginInput = driver.FindElement(By.Id("sso_id"));
            PasswordInput = driver.FindElement(By.Id("sso_password"));
            SignInButton = driver.FindElement(By.Id("btnLogin"));
            ForgotYourPassword = driver.FindElement(By.LinkText("Forgot Password?"));
        }
        #region Atomic Operations
        public void InputLogin(string login)
        {
            LoginInput.Click();
            LoginInput.Clear();
            LoginInput.SendKeys(login);
        }
        
        public void InputPassword(string password)
        {
            PasswordInput.Click();
            PasswordInput.Clear();
            PasswordInput.SendKeys(password);
        }
        public void SignIn()
        {
            SignInButton.Click();
        }
        #endregion

        #region Business Logic
        public HomePage LogIn(IWebDriver driver,string login, string password)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            InputLogin(login);
            InputPassword(password);
            SignInButton.Click();
            return new HomePage();
        }
        #endregion
    }
}
