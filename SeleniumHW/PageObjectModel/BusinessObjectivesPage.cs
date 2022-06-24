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
    class BusinessObjectivesPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public BusinessObjectivesPage(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        
        private IWebElement clickAddBusinessObjectiveButton => _driver.FindElement(By.XPath("//span[normalize-space()='Add Business Objective']"));

        private IWebElement clickEditBusinessObjectiveButton => _driver.FindElement(By.XPath("//mat-row[1]//mat-cell[8]//div[1]//i[1]"));
        private IWebElement deleteStatusFilterOfBusinessObjectiveButton => _driver.FindElement(By.XPath("//button[@class='mat-focus-indicator small mat-icon-button mat-button-base ng-star-inserted']"));
        private IWebElement showAllStatusFilterPositionOfBusinessObjective => _driver.FindElement(By.CssSelector(".mat-select-value.ng-tns-c116-14"));
        private IWebElement selectStatusFilterOfBusinessObjective => _driver.FindElement(By.XPath("//span[@class='mat-option-text'][normalize-space()='Achieved']"));
        
        private IWebElement clickDeleteBusinessObjectiveButton => _driver.FindElement(By.XPath("//i[@mattooltip='Delete Business Objective']"));

        private IWebElement clickConfirmationToDeleteBusinessObjectiveButton => _driver.FindElement(By.XPath("//span[normalize-space()='Yes']"));
        private IWebElement clickCancelDeleteBusinessObjectiveButton => _driver.FindElement(By.XPath("//span[normalize-space()='No']"));
        private By popupMessage => By.XPath("//snack-bar-container");
        private IWebElement clickOnSearchInputField => _driver.FindElement(By.XPath("//input[@aria-label='search']"));
        private IWebElement clickOnSearchButton => _driver.FindElement(By.CssSelector(".fas.fa-search.fs-16"));

        private By popupMessage2 => By.XPath("//snack-bar-container");
        private By popupMessage3 => By.XPath("//div[@class='cdk-overlay-container']");
        private By popupMessage4 => By.XPath("//div[@class='cdk-overlay-container']");




        public void ClickAddBusinessObjective()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickAddBusinessObjectiveButton)).Click();

        }
        public void ClickEditBusinessObjective()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickEditBusinessObjectiveButton)).Click();

        }

        public void ClickDeleteStatusFilter()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(deleteStatusFilterOfBusinessObjectiveButton)).Click();

        }
        public void ExpandStatusFilterPositions()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(showAllStatusFilterPositionOfBusinessObjective)).Click();

        }
        public void SelectStatusFilterPosition()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectStatusFilterOfBusinessObjective)).Click();

        }
        public void ClickDeleteBusinessObjectiveButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickDeleteBusinessObjectiveButton)).Click();

        }
        public void ClickConfirmationToDeleteBusinessObjectiveButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickConfirmationToDeleteBusinessObjectiveButton)).Click();

        }
        public void ClickCancelDeleteBusinessObjectiveButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickCancelDeleteBusinessObjectiveButton)).Click();

        }
        public void MessageBusinessObjectiveSave()
        {
            _wait.Until(ExpectedConditions.TextToBePresentInElement(_driver.FindElement(popupMessage), "Business Objective added successfully"));
        }
        public void MessageBusinessObjectiveEditedSave()
        {
            _wait.Until(ExpectedConditions.TextToBePresentInElement(_driver.FindElement(popupMessage3), "Business Objective updated successfully"));
        }
        public void MessageBusinessObjectiveDeleted()
        {
            _wait.Until(ExpectedConditions.TextToBePresentInElement(_driver.FindElement(popupMessage4), "Business objective deleted successfully"));
        }
        public void ClickOnSearchInputField(string WriteBusinessObjectiveName)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickOnSearchInputField)).SendKeys(WriteBusinessObjectiveName);
        }
        public void WriteInSearchInputField(string BusinessObjectiveName2)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickOnSearchInputField)).SendKeys(BusinessObjectiveName2);
        }
        public void ClickOnSearchButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickOnSearchButton)).Click();
        }
    }
}
