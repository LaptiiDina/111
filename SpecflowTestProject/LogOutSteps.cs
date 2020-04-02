using System;
using TechTalk.SpecFlow;

namespace SpecflowTestProject
{
    [Binding]
    public class LogOutSteps
    {
        [When(@"I click the link ""(.*)""")]
        public void WhenIClickTheLink(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I successfully logouted in NewBookModels as created client")]
        public void ThenISuccessfullyLogoutedInNewBookModelsAsCreatedClient()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
