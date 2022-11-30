

using MarsQA.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.DOM;
using OpenQA.Selenium.Support.UI;
using static System.Net.Mime.MediaTypeNames;

IWebDriver driver = new ChromeDriver();



LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginSteps(driver);

ProfilePage profilePageObj = new ProfilePage();
profilePageObj.ProfileEditPage(driver);




driver.Close();