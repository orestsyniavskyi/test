using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AgileCraftTests.Pages
{
    class AddStoryWindow
    {
        IWebDriver driver = WebDriverSingleton.getInstance();
        private IWebElement StoryNameTextBox { get { return driver.FindElement(By.XPath("/input[@id='txtName']")); } }
        private IWebElement StoryDescriptionTextBox { get { return driver.FindElement(By.XPath("//body[@contenteditable='true']")); } }
        private IWebElement ProgramChooseBox { get { return driver.FindElement(By.XPath("//*[@id='cmbIterationGroupX_chosen']")); } }
        private IWebElement ProgramTextBox { get { return driver.FindElement(By.XPath("//*[@class='chosen-search-input']")); } }
        private IWebElement SaveAndCloseButton { get { return driver.FindElement(By.ClassName("btnAdd_A_close btn btn-primary btnSubmit")); } }
        
        public void FillInStoryName(string s)
        {
            StoryNameTextBox.Click();
            StoryNameTextBox.Clear();
            StoryNameTextBox.SendKeys(s);
        }
        public void FillInStoryDescription(string s)
        {
            StoryDescriptionTextBox.Click();
            StoryDescriptionTextBox.Clear();
            StoryDescriptionTextBox.SendKeys(s);
        }
        public void ChooseTheProgram(string s)
        {
            ProgramChooseBox.Click();
            ProgramTextBox.Click();
            ProgramTextBox.Clear();
            ProgramTextBox.SendKeys(s);
        }
        public HomePage PressSaveAndClose()
        {
            SaveAndCloseButton.Click();
            return new HomePage();
        }
    }
}
