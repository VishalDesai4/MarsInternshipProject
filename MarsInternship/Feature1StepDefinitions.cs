using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System;
using TechTalk.SpecFlow;

namespace MarsInternship
{
    [Binding]
    public class Feature1StepDefinitions : CommonDriver
    {
        private IWebDriver driver;
        [Given(@"\[I am on the log in page ]")]
        public void GivenIAmOnTheLogInPage()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SignIn.Click();
        }

        [Given(@"\[I enter valid  <username> and <password>")]
        public void GivenIEnterValidUsernameAndPassword()
        {
            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.SendKeys("desaivis@gmail.com");
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("testmarslogin");
        }

        [When(@"\[I click on the log in button]")]
        public void WhenIClickOnTheLogInButton()
        {
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
        }

        [Then(@"\[I shoud be able to sig n in succesfully ]")]
        public void ThenIShoudBeAbleToSigNInSuccesfully(Table table)
        {
           
        }





        [Given(@"\[I am navigating the log in page]")]
        public void GivenIAmNavigatingTheLogInPage()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SignIn.Click();
        }

        [Given(@"\[I enter Invalid <username> and valid <password>]")]
        public void GivenIEnterInvalidUsernameAndValidPassword()
        {
            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.SendKeys("User1");
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("Password1");
        }

        [When(@"\[click on the log in button]")]
        public void WhenClickOnTheLogInButton()
        {
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
        }

        [Then(@"\[I should be able to get error message]")]
        public void ThenIShouldBeAbleToGetErrorMessage(Table table)
        {
          
            
        }




        [Given(@"\[\tI navigate to profile page ]")]
        public void GivenINavigateToProfilePage()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SignIn.Click();
        }

        [When(@"\[Click on add new button]")]
        public void WhenClickOnAddNewButton()
        {
            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton.Click();
        }           

        [Then(@"\[Click on cancel to cancel it]")]
        public void ThenClickOnCancelToCancelIt()
        {
            IWebElement AddNewButtonCancel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
            AddNewButtonCancel.Click(); 
        }





        [Given(@"\[\tI am on profile page ]")]
        public void GivenIAmOnProfilePage()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SignIn.Click();
        }

        [Given(@"\[Click on add new button]")]
        public void GivenClickOnAddNewButton()
        {
            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton.Click();
        }

        [Given(@"\[ write language thats wants to ad]")]
        public void GivenWriteLanguageThatsWantsToAd()
        {
            IWebElement WriteNameOfLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            WriteNameOfLanguage.SendKeys("Hindi");
        }

        [Given(@"\[select level of language as expert]")]
        public void GivenSelectLevelOfLanguageAsExpert()
        {
            IWebElement ClickPullDownMenu = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            ClickPullDownMenu.Click();
            IWebElement SelectLevelofProficiency = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            SelectLevelofProficiency.Click();   
        }

        [When(@"\[click  on add button]")]
        public void WhenClickOnAddButton()
        {
            IWebElement Add = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            Add.Click();
        }

        [Then(@"\[I should be able to see raw for language has been added]")]
        public void ThenIShouldBeAbleToSeeRawForLanguageHasBeenAdded(Table table)
        {
            
        }

        [Given(@"\[I will navigate to profile page ]")]
        public void GivenIWillNavigateToProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"\[click delet button]")]
        public void WhenClickDeletButton()
        {
            throw new PendingStepException();
        }

        [Then(@"\[I should be able to message for language has bee deleted]")]
        public void ThenIShouldBeAbleToMessageForLanguageHasBeeDeleted()
        {
            throw new PendingStepException();
        }

        [Given(@"\[Click on Edit record and Cancel record]")]
        public void GivenClickOnEditRecordAndCancelRecord()
        {
            throw new PendingStepException();
        }

        [When(@"\[Edit rlanguage record and change level of proficiency]")]
        public void WhenEditRlanguageRecordAndChangeLevelOfProficiency()
        {
            throw new PendingStepException();
        }

        [Then(@"\[I should be able to upate record]")]
        public void ThenIShouldBeAbleToUpateRecord()
        {
            throw new PendingStepException();
        }

        [Given(@"\[\tI will click on profile page ]")]
        public void GivenIWillClickOnProfilePage()
        {
            throw new PendingStepException();
        }

        [Given(@"\[click on ""([^""]*)""]")]
        public void GivenClickOn(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"\[write First skill that you have to share it]")]
        public void GivenWriteFirstSkillThatYouHaveToShareIt()
        {
            throw new PendingStepException();
        }

        [Given(@"\[ click pull down menu]")]
        public void GivenClickPullDownMenu()
        {
            throw new PendingStepException();
        }

        [Given(@"\[select level of skill]")]
        public void GivenSelectLevelOfSkill()
        {
            throw new PendingStepException();
        }

        [When(@"\[click add button]")]
        public void WhenClickAddButton()
        {
           
        }

        [Then(@"\[I should be able to see skill that has been added]")]
        public void ThenIShouldBeAbleToSeeSkillThatHasBeenAdded(Table table)
        {
            
        }

        [When(@"\[Click on add new  skill button]")]
        public void WhenClickOnAddNewSkillButton()
        {
            
        }

        [Then(@"\[Click on cancel button to cancel it]")]
        public void ThenClickOnCancelButtonToCancelIt()
        {
            
        }

        [Given(@"\[I will be navigate to profile page ]")]
        public void GivenIWillBeNavigateToProfilePage()
        {
           
        }

        [Given(@"\[Click on Edit button and Cancel record by cliking cancel]")]
        public void GivenClickOnEditButtonAndCancelRecordByClikingCancel()
        {
            
        }

        [When(@"\[Edit skill record and change level of  skill proficiency]")]
        public void WhenEditSkillRecordAndChangeLevelOfSkillProficiency()
        {
            
        }

        [Then(@"\[I should be able to upate skill record]")]
        public void ThenIShouldBeAbleToUpateSkillRecord()
        {
            
        }




        [Given(@"\[I will naviagte to skill page ]")]
        public void GivenIWillNaviagteToSkillPage()
        {
           
        }

        [When(@"\[click delete button on skill]")]
        public void WhenClickDeleteButtonOnSkill()
        {
            
        }

        [Then(@"\[I should be able delete skill raw]")]
        public void ThenIShouldBeAbleDeleteSkillRaw()
        {
            
        }
    }

    public class CommonDriver
    {
    }
}
