using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AgileCraftTests.Pages
{
    class WorkItem:Header
    {
        IWebDriver driver = WebDriverSingleton.getInstance();
        private IWebElement StoryButton { get {return driver.FindElement(By.ClassName("icon icon-book-open-bookmarked-1")); } }

        public AddStoryWindow ClickStoryButton()
        {
            StoryButton.Click();
            return new AddStoryWindow();
        }
    }
}
