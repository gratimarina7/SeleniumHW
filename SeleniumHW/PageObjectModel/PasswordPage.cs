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
    public class PasswordPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private WebDriverWait _customWait;

        public PasswordPage(IWebDriver driver, WebDriverWait wait, WebDriverWait customwait)
           {
              _driver = driver;
              _wait = wait;
              _customWait = customwait;
          }

        private IWebElement signInButton => _driver.FindElement(By.XPath("//input[@value='Sign in']"));

        public void WritePassword(string password)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='password']"))).SendKeys(password);
        }

        public void PressSignInButton()
        {
            _customWait.Until(ExpectedConditions.ElementToBeClickable(signInButton)).Click();
        }

    }

}
