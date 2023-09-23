using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsInternship.Pages
{
    public class LogIn
    {
        public void LoginActions(IWebDriver driver) 
        {
            //launch mars portal and navigate to sign in
            driver.Navigate().GoTourl("http://localhost:5000/");

            //identify signin button and click button
            IWebElement SignIn = driver.FindElement("//*[@id=\"home\"]/div/div/div[1]/div/a");
            SignIn.Click();

            //Identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Xpath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.Sendkeys("desaivis@gmail.com");

            //Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.Sendkeys("testmarslogin");

            //identify log in butto nand click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();








        }








    }
}
