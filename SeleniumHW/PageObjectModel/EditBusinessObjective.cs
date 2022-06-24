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
    public class EditBusinessObjective
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public EditBusinessObjective(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement editBusinessObjectiveField => _driver.FindElement(By.XPath("//textarea[@id ='mat-input-1']"));
        private IWebElement editBusinessObjectiveOutputField => _driver.FindElement(By.XPath("//textarea[@id ='mat-input-2']"));
        private IWebElement clickStatusField => _driver.FindElement(By.XPath("//mat-select[@formcontrolname='statusId']"));
        private IWebElement editStatusField => _driver.FindElement(By.XPath("//span[@class='mat-option-text'][normalize-space()='In progress']"));
        private IWebElement editStatusField2 => _driver.FindElement(By.XPath("//span[@class='mat-option-text'][normalize-space()='Achieved']"));
        private IWebElement clickPriorityField => _driver.FindElement(By.XPath("//mat-select[@formcontrolname='priorityId']"));
        private IWebElement selectPriorityField => _driver.FindElement(By.XPath("//span[@class='mat-option-text'][normalize-space()='High']"));
        private IWebElement selectPriorityField2 => _driver.FindElement(By.XPath("//span[@class='mat-option-text'][normalize-space()='High']"));
        private IWebElement clickOnCalendar => _driver.FindElement(By.XPath("//button[@aria-label='Open calendar']//span[@class='mat-button-wrapper']//*[name()='svg']"));
        private IWebElement selectDeadlineMonth=> _driver.FindElement(By.XPath("//button[@aria-label='Next month']"));
        private IWebElement selectDeadlineDate => _driver.FindElement(By.XPath("//div[normalize-space()='26']"));
        private IWebElement selectDeadlineDate2 => _driver.FindElement(By.XPath("//div[normalize-space()='28']"));
        private IWebElement saveEditedBusinessObjective => _driver.FindElement(By.XPath("//span[normalize-space()='Save']"));
        private IWebElement cancelEditedBusinessObjective => _driver.FindElement(By.XPath("//span[normalize-space()='Cancel']"));


        public void EditBusinessObjectives(string editBusinessObjective)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(editBusinessObjectiveField)).Clear();
            _wait.Until(ExpectedConditions.ElementToBeClickable(editBusinessObjectiveField)).SendKeys(editBusinessObjective);
        }
        public void EditBusinessObjectiveOutput(string editBusinessObjectiveOutput)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(editBusinessObjectiveOutputField)).Clear();
            _wait.Until(ExpectedConditions.ElementToBeClickable(editBusinessObjectiveOutputField)).SendKeys(editBusinessObjectiveOutput);

        }
        public void ClickStatusInput()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickStatusField)).Click();

        }
        public void SelectStatusInput()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(editStatusField)).Click();

        }
        public void SelectStatusInput2()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(editStatusField2)).Click();

        }
        public void ClickPriorityInput()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickPriorityField)).Click();

        }
        public void SelectPriorityInput()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectPriorityField)).Click();

        }
        public void SelectPriorityInput2()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectPriorityField2)).Click();

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
        public void SelectDeadlineDate2()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectDeadlineDate2)).Click();

        }
        public void SaveEditedBusinessObjective()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(saveEditedBusinessObjective)).Click();

        }
        public void CancelEditedBusinessObjective()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(cancelEditedBusinessObjective)).Click();

        }

    }
}
