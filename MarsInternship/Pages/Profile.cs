using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsInternship.Pages
{
    public class Profile
    {

        public void GoToProfilePage(IWebDriver driver)
        {
            //Navigate to Availability for share skill
            IWebelement EditAvailability = (IWebelement)driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            EditAvailability.Click();

            //Navigate to availability option for share skill
            IWebElement AvailabilityDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            AvailabilityDropDown.Click();

            //Select options for availability on share skill
            IWebElement SelectFullTime = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            SelectFullTime.Click();

            IWebElement PartTime = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[1]/div/span"));
            PartTime.Click();

            //Navigate to Hours of service that you will provide on share skill
            IWebelement EditHours = (IWebelement)driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            EditHours.Click();

            //Navigate to availability option for share skill
            IWebElement HoursDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            HoursDropDown.Click();

            //Select options for Hours of service that you will provide share skill platform
            IWebElement lessThan30Hours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[1]/div/div/div/div/div/div[3]/div/div[1]/div/span"));
            lessThan30Hours.Click();

            IWebElement MoreThan30Hours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            MoreThan30Hours.Click();

            IWebElement AsNeeded = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
            AsNeeded.Click();

            //Navigate to EditTarget for share skill
            IWebelement EditTarget = (IWebelement)driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            EditTarget.Click();

            //Navigate to  select Earn Target option for share skill
            IWebElement TargetDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
            TargetDropDown.Click();

            //Select options for Earning a target of service that you will provide share skill platform
            IWebElement SelectLessThan500 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[1]/div/div[4]/div/span"));
            SelectLessThan500.Click();

            IWebElement SelectBetween500And1000 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div[4]/div/span"));
            SelectBetween500And1000.Click();

            IWebElement SelectMoreThan1000 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));
            SelectMoreThan1000.Click();

        }
    }
}