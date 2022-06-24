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
    class ProjectsPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public ProjectsPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement clickAddProjectButton => _driver.FindElement(By.XPath("//a[@id='addProjectButton']"));

        private IWebElement selectBusinessObjectives => _driver.FindElement(By.XPath("//a[normalize-space()='Business Objectives']"));

        private IWebElement selectRiskRegister => _driver.FindElement(By.XPath("//a[normalize-space()='Risk Register']"));

        private IWebElement selectCollaborationRetrospectiveNotes => _driver.FindElement(By.XPath("//a[contains(text(),'Collaboration')]"));

        public void ClickAddProjectButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickAddProjectButton)).Click();

        }
        public void SelectBusinessObjectives()
        {
           _wait.Until(ExpectedConditions.ElementToBeClickable(selectBusinessObjectives)).Click();

         }
        public void SelectRiskRegister()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectRiskRegister)).Click();

        }
        public void SelectCollaborationRetrospectiveNotes()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectCollaborationRetrospectiveNotes)).Click();

        }
    }
}

