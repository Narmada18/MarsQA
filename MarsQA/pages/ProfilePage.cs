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
            Thread.Sleep(1000);
            IWebElement hiNarmadaDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            hiNarmadaDropdown.Click();

            IWebElement goToProfile = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div"));

            Thread.Sleep(1000);

            goToProfile.Click();


            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            editButton.Click();

            IWebElement availabiltyTypeButton = driver.FindElement(By.Name("availabiltyType"));
            availabiltyTypeButton.Click();
            Thread.Sleep(500);

            IWebElement dropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]"));
            dropDown.Click();

            IWebElement hoursButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            hoursButton.Click();

            Thread.Sleep(1000);

            IWebElement dropDown1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            dropDown1.Click();
        }
    }
}
