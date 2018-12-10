using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using OpenQA.Selenium;
using AgileCraftTests.Pages;
using AgileCraftTests.Other;

namespace AgileCraftTests.Steps
{
    class Create_a_story
    {
        IWebDriver driver = WebDriverSingleton.getInstance();

        [Given(@"I press create button and choose story")]
        public void GivenIPressCreateButtonAndChooseStory()
        {
            HomePage homePage = new HomePage();
            homePage.CreateButtonClick().ClickStoryButton();
        }

        [Given(@"Fill in boxes with data from the table and press Save&Close")]
        public void GivenFillInBoxesWithDataFromTheTableAndPressSaveClose(Table table)
        {
            AddStoryWindow storyWindow = new AddStoryWindow();
            DataSet dataSet = table.CreateInstance<DataSet>();
            storyWindow.FillInStoryName(dataSet.storyName);
            storyWindow.FillInStoryDescription(dataSet.storyDescription);
            storyWindow.ChooseTheProgram(dataSet.programName);
        }


        [When(@"I check the story list")]
        public void WhenICheckTheStoryList()
        {
            
        }

        [Then(@"Appropriate story must be presented")]
        public void ThenAppropriateStoryMustBePresented()
        {
            
        }

    }
}
