using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace Framework_Marina.PageObjectModel
{
    class AddNewBusinessObjective
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        static DateTime now = DateTime.Now;
        private int today = now.Day;

        public AddNewBusinessObjective(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement completeBusinessObjectiveField => _driver.FindElement(By.XPath("//textarea[@id ='mat-input-1']"));
        private IWebElement completeBusinessObjectiveOutputField => _driver.FindElement(By.XPath("//textarea[@id ='mat-input-2']"));
        private IWebElement clickStatusField => _driver.FindElement(By.XPath("//mat-select[@formcontrolname='statusId']"));
        private IWebElement selectStatusField => _driver.FindElement(By.XPath("//span[@class='mat-option-text'][normalize-space()='Not Started']"));
        private IWebElement clickPriorityField => _driver.FindElement(By.XPath("//mat-select[@formcontrolname='priorityId']"));
        private IWebElement selectPriorityField => _driver.FindElement(By.XPath("//span[@class='mat-option-text'][normalize-space()='Low']"));
        private IWebElement clickOnCalendar => _driver.FindElement(By.XPath("//button[@aria-label='Open calendar']//span[@class='mat-button-wrapper']//*[name()='svg']"));
        private IWebElement selectDeadlineMonth => _driver.FindElement(By.XPath("//button[@aria-label='Next month']"));
        private IWebElement selectDeadlineDate => _driver.FindElement(By.XPath("//div[normalize-space()='16']"));
        private IWebElement saveNewBusinessObjective => _driver.FindElement(By.XPath("//span[normalize-space()='Save']"));
        private IWebElement canceltoAddBusinessObjective => _driver.FindElement(By.XPath("//span[normalize-space()='Cancel']"));
       

        public void WhriteBusinessObjective(string BusinessObjective)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(completeBusinessObjectiveField)).SendKeys(BusinessObjective);
        }
        public void WhriteBusinessObjectiveOutput(string BusinessObjectiveOutput)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(completeBusinessObjectiveOutputField)).SendKeys(BusinessObjectiveOutput);
        }
        public void ClickStatusField()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickStatusField)).Click();
        }

        public void SelectStatusInput()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectStatusField)).Click();

        }
        public void ClickPriorityInput()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickPriorityField)).Click();

        }
        public void SelectPriorityInput()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectPriorityField)).Click();

        }
        
        public void ClickOnCalendar()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickOnCalendar)).Click();

        }
        public void SelectDeadlineMonth()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectDeadlineMonth)).Click();

        }
        public void SelectDeadlineDate()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectDeadlineDate)).Click();

        }
        public void SaveNewBusinessObjective()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(saveNewBusinessObjective)).Click();

        }
        
    }
}
