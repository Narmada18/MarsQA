using MarsQA.utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.pages
{
    public class EducationPage
    {
        public void educationPage(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//a[@class='item' and text()='Education' ]")).Click();

            Wait.WaitForElement(driver, "XPath", "(//div[@class='ui teal button '])[2]", 10);

            driver.FindElement(By.XPath("(//div[@class='ui teal button '])[2]")).Click();

            driver.FindElement(By.XPath("//input[@name='instituteName']")).SendKeys("JNTU");

            driver.FindElement(By.XPath("//select[@name='country']")).Click();

            driver.FindElement(By.XPath("//option[@value='India']")).Click();

            driver.FindElement(By.XPath("//select[@name='title']")).Click();

            driver.FindElement(By.XPath("//option[@value='M.Tech']")).Click();

            driver.FindElement(By.XPath("//input[@name='degree']")).SendKeys("MCA");

            driver.FindElement(By.XPath("//select[@name='yearOfGraduation']")).Click();

            Wait.WaitForElement(driver, "XPath", "//option[@value='2010']", 10);

            driver.FindElement(By.XPath("//option[@value='2010']")).Click();

            Wait.WaitForElement(driver, "XPath", "//input[@class='ui teal button ' and @value='Add']", 10);

            driver.FindElement(By.XPath("//input[@class='ui teal button ' and @value='Add']")).Click();

            Wait.WaitForElement(driver, "XPath", "(//i[@class='remove icon'])[2]", 5);

            driver.FindElement(By.XPath("(//i[@class='remove icon'])[2]")).Click();


        }
    }
}
