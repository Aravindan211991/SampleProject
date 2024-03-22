using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace SampleProject
{
    [Binding]
    public class TestUserLoginStepDefinitions
    {
        string _userName, _password;

        [Given(@"User enters '([^']*)' and '([^']*)'")]
        public void GivenUserEntersAnd(string username, string password)
        {
            _userName = username;
            _password = password;
        }

        [When(@"User clicks on login")]
        public void WhenUserClicksOnLogin()
        {
            
        }

        [Then(@"Response should be '([^']*)'")]
        public void ThenResponseShouldBeFalse(bool success)
        {
            var result = AuthenticateUsers.AuthenticateUser(_userName, _password);
            result.Should().Be(success);
            
        }

        [Then(@"Logged in Successfully")]
        public void ThenLoggedInSuccessfully()
        {

        }

    }
}
