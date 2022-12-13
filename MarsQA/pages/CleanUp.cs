using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.pages
{
    public class CleanUp
    {
        public void cleanUp(IWebDriver driver)
        {
            driver.Close();
        }
            
            
    }
}
