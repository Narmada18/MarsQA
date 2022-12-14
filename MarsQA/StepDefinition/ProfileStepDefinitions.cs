using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using MarsQA.utilities;
using MarsQA.pages;

namespace MarsQA.StepDefinition
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();
        LanguagePage languagePageObj = new LanguagePage();
        SkillPage skillPageObj = new SkillPage();
        EducationPage educationPageObj = new EducationPage();


        [Given(@"I logged into marsQA successfully")]
        public void GivenILoggedIntoMarsQASuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.LoginSteps(driver);

        }

        [When(@"I navigate to Profile page")]
        public void WhenINavigateToProfilePage()
        {
            profilePageObj.ProfileEditPage(driver);
        }

        [When(@"I update my details")]
        public void WhenIUpdateMyDetails()
        {
            
        }

        [Then(@"The details updated successfully")]
        public void ThenTheDetailsUpdatedSuccessfully()
        {
            
        }

        [Given(@"I enterd all the details")]
        public void GivenIEnterdAllTheDetails()
        {
            
        }

        [When(@"I clicked on add new button")]
        public void WhenIClickedOnAddNewButton()
        {
            
        }

        [Then(@"details added successfully")]
        public void ThenDetailsAddedSuccessfully()
        {
           
        }

        [Given(@"I entered all the skills")]
        public void GivenIEnteredAllTheSkills()
        {
            
        }

        [When(@"I clicked on add new")]
        public void WhenIClickedOnAddNew()
        {
            
        }

        [When(@"clicked on add button")]
        public void WhenClickedOnAddButton()
        {
           
        }

        [Then(@"Skills updated successfully")]
        public void ThenSkillsUpdatedSuccessfully()
        {
            
        }

        [Given(@"I entered all the details")]
        public void GivenIEnteredAllTheDetails()
        {
           
        }

        [When(@"I clicked add new button")]
        public void WhenIClickedAddNewButton()
        {
            
        }

        [When(@"clicked add button")]
        public void WhenClickedAddButton()
        {
           
        }
    }
}
