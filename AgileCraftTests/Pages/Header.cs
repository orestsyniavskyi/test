using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AgileCraftTests.Pages
{
    class Header
    {
        IWebDriver driver = WebDriverSingleton.getInstance();
        protected IWebElement Label { get { return driver.FindElement(By.ClassName("main-logo-wrapper")); } }
        protected IWebElement CreateButton { get { return driver.FindElement(By.XPath("//button[@title='Create Work Items']" )); } }
        protected IWebElement TopSearchIcon { get; set; } //i[@class='icon icon-search']
        protected IWebElement AlarmIcon { get; set; }
        protected IWebElement TaskIcon { get; set; }
        protected IWebElement PersonIcon { get; set; }
        protected IWebElement ConfigurationIcon { get; set; }
        protected IWebElement AdditionalConfigurationItem { get; set; }
        protected IWebElement UserMenuIcon { get; set; }
        protected IWebElement SideSearchIcon { get; set; }
        protected IWebElement FavoriteIcon { get; set; }
        protected IWebElement EnterpriseIcon { get; set; }
        protected IWebElement PortfolioIcon { get; set; }
        protected IWebElement SolutionIcon { get; set; }
        protected IWebElement ProgramIcon { get; set; }
        protected IWebElement TeamIcon { get; set; }
        protected IWebElement ProductIcon { get; set; }
        protected IWebElement ReportsIcon { get; set; }
        protected IWebElement CollaborateIcon { get; set; }
        protected IWebElement AdministrationIcon { get; set; }

        public Header()
    {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }
        public bool isLogoDisplayed()
        {
            return Label.Displayed;
        }

        public WorkItem CreateButtonClick()
        {
            CreateButton.Click();
            return new WorkItem();
        }
    }
    
}
