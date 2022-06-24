using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Marina.PageObjectModel
{
    class DashboardPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;


        public DashboardPage (IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;

        }

        private IWebElement selectProjectPage => _driver.FindElement(By.XPath("//a[@id='projects-tab']"));

        public void ClickProjectsButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectProjectPage)).Click();

        }
       
    }
}


