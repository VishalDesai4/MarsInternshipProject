using System;
using TechTalk.SpecFlow;

namespace MarsInternship
{
    [Binding]
    public class ProfileStepDefinitions
    {
        [Given(@"\[User enters desaivis@gmail\.com as username and testmarslogin as password]")]
        public void GivenUserEntersDesaivisGmail_ComAsUsernameAndTestmarsloginAsPassword()
        {
            throw new PendingStepException();
        }

        [When(@"\[Click on log in button]")]
        public void WhenClickOnLogInButton()
        {
            throw new PendingStepException();
        }

        [Then(@"\[User should have log in succesfully]")]
        public void ThenUserShouldHaveLogInSuccesfully()
        {
            throw new PendingStepException();
        }

        [Then(@"\[User should have not log in and receive a message for invalid username]")]
        public void ThenUserShouldHaveNotLogInAndReceiveAMessageForInvalidUsername()
        {
            throw new PendingStepException();
        }
    }
}
