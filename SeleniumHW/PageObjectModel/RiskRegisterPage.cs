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
    class RiskRegisterPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public RiskRegisterPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement clickAddProjectRiskButton => _driver.FindElement(By.XPath("//span[@class='icon-btn-label']"));

        

        public void ClickAddProjectRiskButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickAddProjectRiskButton)).Click();

        }
        
    }
}
