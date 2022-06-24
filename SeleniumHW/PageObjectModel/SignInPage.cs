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
    public class SignInPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public SignInPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;

        }

        private IWebElement checkboxField => _driver.FindElement(By.XPath("//input[@type='checkbox']"));
        private IWebElement yesButton => _driver.FindElement(By.XPath("//input[@value='Yes']"));

        public void TickCheckbox()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(checkboxField)).Click();
        }

        public void PressYesnButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(yesButton)).Click();
        }

    }

}
