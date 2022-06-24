using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Framework_Marina.PageObjectModel
{
    public class EmailPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private WebDriverWait _customWait;

        public EmailPage(IWebDriver driver, WebDriverWait wait, WebDriverWait customWait)
        {
            _driver = driver;
            _wait = wait;
            _customWait = customWait;
        }

        private IWebElement emailField => _driver.FindElement(By.XPath("//input[@type='email']"));
        private IWebElement nextButton => _driver.FindElement(By.XPath("//input[@value='Next']"));
        private By errorMessage => By.Id("usernameError");



        public void WriteEmail(string email)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(emailField)).SendKeys(email);
        }

        public void PressNextButton()
        {
            _customWait.Until(ExpectedConditions.ElementToBeClickable(nextButton)).Click();
        }
    }

}



