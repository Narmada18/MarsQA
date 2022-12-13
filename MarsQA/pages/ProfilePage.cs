using MarsQA.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.pages
{
    public class ProfilePage
    {
        public void ProfileEditPage(IWebDriver driver)
        {
            Wait.WaitForElement(driver, "XPath","//span[@class='item ui dropdown link ']", 10);

            driver.FindElement(By.XPath("//span[@class='item ui dropdown link ']")).Click();

            Wait.WaitToBeVisible(driver, "XPath", "//a[@class='item' and text()='Go to Profile']", 10);

            driver.FindElement(By.XPath("//a[@class='item' and text()='Go to Profile']")).Click();

            Wait.WaitForElement(driver, "XPath", "//i[@class='right floated outline small write icon']", 10);

            driver.FindElement(By.XPath("//i[@class='right floated outline small write icon']")).Click();
                     
            driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown']")).Click();

            Wait.WaitForElement(driver, "XPath", "//option[@value='0']", 10);

            driver.FindElement(By.XPath("//option[@value='0']")).Click();
           
            driver.FindElement(By.XPath("(//*[@class='right floated outline small write icon'])[2]")).Click();

            Wait.WaitForElement(driver, "XPath","//select[@name='availabiltyHour']", 10);

            driver.FindElement(By.XPath("//select[@name='availabiltyHour']")).Click();
            
            driver.FindElement(By.XPath("//option[text()='Less than 30hours a week' and @value='0']")).Click();
         
                      
        }
    }
}                                                                   