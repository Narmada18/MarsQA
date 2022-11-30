using MarsQA.utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.pages
{
    public class LoginPage
    {
        private IWebElement emailTextbox;

        public void LoginSteps(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");

            Thread.Sleep(500);

            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signInButton.Click();

           Wait.WaitForElement(driver, "Name", "email", 5);

            //Thread.Sleep(1000);

            IWebElement emailTextbox = driver.FindElement(By.Name("email"));
            emailTextbox.SendKeys("narmada.nettem@gmail.com");

            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("123456");

            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(1000);
        }
    }
}
