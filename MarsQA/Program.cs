

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();

driver.Navigate().GoToUrl("http://localhost:5000/");

Thread.Sleep(500);

IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
signInButton.Click();
Thread.Sleep(1000);

IWebElement emailTextbox = driver.FindElement(By.Name("email"));
emailTextbox.SendKeys("narmada.nettem@gmail.com");

IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
passwordTextbox.SendKeys("123456");

IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
loginButton.Click();
Thread.Sleep(1000);

IWebElement hiNarmadaDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
hiNarmadaDropdown.Click();

IWebElement goToProfile = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div"));

Thread.Sleep(500);
goToProfile.Click();