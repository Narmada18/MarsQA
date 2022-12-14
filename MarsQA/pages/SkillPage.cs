using MarsQA.utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.pages
{
    public class SkillPage
    {
        public void skillPage(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, "XPath", "//a[@class='item' and text()='Skills']", 10);

            driver.FindElement(By.XPath("//a[@class='item' and text()='Skills']")).Click();

            driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();

            driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("ISTQB");

            Wait.WaitToBeVisible(driver, "XPath", "//select[@name='level']", 10);

            driver.FindElement(By.XPath("//select[@name='level']")).Click();

            driver.FindElement(By.XPath("//option[@value='Beginner']")).Click();

            driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

            Wait.WaitToBeVisible(driver, "XPath", "//i[@class='remove icon']", 10);

            driver.FindElement(By.XPath("//i[@class='remove icon']")).Click();




        }
    }
}
