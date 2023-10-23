using NUnit.Framework;
using Octokit;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsInternship.Pages
{   
    public class LogIn
    {
        public void LogInActions(IWebDriver driver)
        {
            //launch mars portal and navigate to sign in
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //identify signin button and click button
            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SignIn.Click();

            try
            {

                //Identify username textbox and enter valid username
                IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                usernameTextbox.SendKeys("desaivis@gmail.com");
            }

            catch (Exception)

            {
                Assert.Fail("Mars project portal page didnot launch,ex.messsage");
            }
                
            //Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("testmarslogin");
  
            //identify log in button nand click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();








        }

        internal void LogInActions(object driver)
        {
            throw new NotImplementedException();
        }
    }
}
