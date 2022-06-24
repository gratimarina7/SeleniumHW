using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using OpenQA.Selenium.Chrome;


namespace Framework_Marina.PageObjectModel
{
    public class LogInPage 
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        

        public LogInPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;

        }

        private IWebElement loginButton => _driver.FindElement(By.CssSelector("div .button>span"));
        private By errorMessage => By.CssSelector("html head title");

        public void ClickLoginButton()
        {
            Assert.AreEqual("Log In", loginButton.Text);
            _wait.Until(ExpectedConditions.ElementToBeClickable(loginButton)).Click();

            
        }
    }
}
