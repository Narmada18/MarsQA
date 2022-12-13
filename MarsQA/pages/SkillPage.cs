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
            driver.FindElement(By.XPath("//a[@class='item' and text()='Skills']")).Click();

            driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();

            driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("ISTQB");

            driver.FindElement(By.XPath("(//select[@name='level'])[1]"));





        }
    }
}
