using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowTestProject.NewBookModelsPOM;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestApiProject.ApiRequests.NewBookModelsApi.Auth;

namespace SpecflowTestProject.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        private IWebDriver _driver = ((IWebDriver)ScenarioContext.Current["driver"]);

        //[Given(@"Client is new")]
        //public void GivenClientIsNew()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        [Given(@"Sign out page is opened")]
        public void GivenSignOutPageIsOpened()
        {
            new Registration(_driver).RegistrPageIsOpened();
        }
        
        [When(@"I input first name of a new client in First Name field")]
        public void WhenIInputFirstNameOfANewClientInFirstNameField()
        {
            new Registration(_driver).FirstNameField("qweasd" + DateTime.Now.ToString("hhmmss"));
        }
        
        [When(@"I input last name of a new client in Last Name field")]
        public void WhenIInputLastNameOfANewClientInLastNameField()
        {
            new Registration(_driver).LastNameField("qweasd" + DateTime.Now.ToString("hhmmss"));
        }
        
        [When(@"I input email of a new client in Email field")]
        public void WhenIInputEmailOfANewClientInEmailField()
        {
            new Registration(_driver).EmailField("qweasd" + DateTime.Now.ToString("hhmmss")+"@qwe.com");
        }
        
        [When(@"I input password of a new client in Password  field")]
        public void WhenIInputPasswordOfANewClientInPasswordField()
        {
            new Registration(_driver).FillPasswordField("123qweQWE!");
        }
        
        [When(@"I input Confirm Password of a new client in Confirm Password  field")]
        public void WhenIInputConfirmPasswordOfANewClientInConfirmPasswordField()
        {
            new Registration(_driver).FillConfirmPassword("123qweQWE!");
        }
        
        [When(@"I input Mobile of a new client in Mobile field")]
        public void WhenIInputMobileOfANewClientInMobileField()
        {
            new Registration(_driver).FillPhone("1231231231");
        }
        
        [When(@"I click Next button")]
        public void WhenIClickNextButton()
        {
            new Registration(_driver).ClickLogInBtn();
        }
        
        [Then(@"I successfully registered in NewBookModels as new client")]
        public void ThenISuccessfullyRegisteredInNewBookModelsAsNewClient()
        {
            Thread.Sleep(5000);
            Assert.True(new ClientSignUpPage(_driver).IsFinishBtnDisplayed());
        }
    }
}
