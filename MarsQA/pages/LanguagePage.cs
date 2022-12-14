using MarsQA.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.pages
{
    public class LanguagePage
    {
        public void languagePage(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//a[@class='item active']")).Click();
            
            driver.FindElement(By.XPath("(//div[@class='ui teal button '])[1]")).Click();

            driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']")).SendKeys("English");

            driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();

            driver.FindElement(By.XPath("//option[@value='Basic']")).Click();

            driver.FindElement(By.XPath("(//input[@value='Add'])[1]")).Click();

            Wait.WaitToBeVisible(driver, "XPath", "//i[@class='remove icon']", 10);

            driver.FindElement(By.XPath("//i[@class='remove icon']")).Click();
            
        }
       
    }
}
