using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowTestProject.NewBookModelsPOM;
using System;
//using System.Runtime.Remoting.Contexts;
using System.Threading;
using TechTalk.SpecFlow;
using TestApiProject;
using TestApiProject.ApiRequests.NewBookModelsApi.Auth;
using TestApiProject.Tests;

namespace SpecflowTestProject.Steps
{
    [Binding]
    public class LogOutSteps
    {
        private readonly IWebDriver _driver = (IWebDriver)ScenarioContext.Current["driver"];
        [Given(@"I login, using API")]
        public void GivenILoginUsingAPI()
        {
            //    Context.Token = new AuthRequests().SendRequestSignUpPost(new ClientSignUpModel
            //    {
            //        Email = "gfdfd" + DateTime.Now.ToString("ddmmyyyyhhmmss") + "f@ll.com",
            //        Password = "123qweQWE!",
            //        FirstName = "sdfsadfsf",
            //        LastName = "asdadasdsad",
            //        PhoneNumber = "1231231231"
            //    }).TokenData.Token;
            //    IJavaScriptExecutor js = (ChromeDriver)_driver;
            //    js.ExecuteScript($"localStorage.setItem('access_token','{Context.Token}');");
            //var leadRegistrationData = new ClientSignUpModel
            //{
            //    Email = "gfdfd" + DateTime.Now.ToString("ddmmyyyyhhmmss") + "f@ll.com",
            //    Password = "123qweQWE!",
            //    FirstName = "sdfsadfsf",
            //    LastName = "asdadasdsad",
            //    PhoneNumber = "1231231231"
            //};

            //var authRequests = new AuthRequests();
            //var leadRegistrationResponseData = authRequests.SendRequestSignUpPost(leadRegistrationData);
            ////string Token = leadRegistrationResponseData.TokenData.Token;
            //Context.Token = leadRegistrationResponseData.TokenData.Token;

            //// var driver = new ChromeDriver();
            //IJavaScriptExecutor js = (ChromeDriver)_driver;
            //// driver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");
            //js.ExecuteScript($"localStorage.setItem('access_token','{Context.Token}');");
            //_driver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");
            //  Thread.Sleep(3000);
            ////  var result = driver.FindElement(By.CssSelector("div[class^='Avatar'] > div[class^='AvatarClient']")).Displayed;
            new TestsUsingApi().CheckThatLoginUsingTokenFromApiInBrowserIsPossible();
        }

        [When(@"I click the link")]
        public void WhenIClickTheLink()
        {
            Thread.Sleep(5000);
            new LogOut(_driver).ClickLink();
        }
        
        [Then(@"I successfully logouted in NewBookModels as  client")]
        public void ThenISuccessfullyLogoutedInNewBookModelsAsClient()
        {
            Thread.Sleep(5000);
            Assert.True(new LogOut(_driver).IsFinishBtnDisplayed());
        }
    }
}
