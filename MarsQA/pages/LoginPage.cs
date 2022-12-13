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
        public void LoginSteps(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();

            Wait.WaitForElement(driver, "XPath", "//a[@class='item']", 5);

            driver.FindElement(By.XPath("//a[@class='item']")).Click();
            
            Wait.WaitForElement(driver, "XPath", ".//*[@name='email']", 5);

            driver.FindElement(By.XPath(".//*[@name='email']")).SendKeys("narmada.nettem@gmail.com");
            
            driver.FindElement(By.XPath("//*[@name='password']")).SendKeys("123456");

            driver.FindElement(By.XPath("//button[@class='fluid ui teal button']")).Click();

        }
    }
}

