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
    class AddNewProjectRisk
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public AddNewProjectRisk(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private IWebElement clickProjectRiskTitle => _driver.FindElement(By.XPath("//mat-select[@formcontrolname='riskTypeId']"));
        private IWebElement selectProjectRiskTitle => _driver.FindElement(By.XPath("//span[normalize-space()='External']"));
        private IWebElement clickProjectRiskTreatmant => _driver.FindElement(By.XPath("//mat-select[@formcontrolname='treatmentId']"));
        private IWebElement selectProjectRiskTreatmant => _driver.FindElement(By.XPath("//span[normalize-space()='Mitigate']"));
        private IWebElement clickProjectRiskImpact => _driver.FindElement(By.XPath("//mat-select[@formcontrolname='impactId']"));
        private IWebElement selectProjectRiskImpact => _driver.FindElement(By.XPath("//span[normalize-space()='Medium']"));
        private IWebElement clickProjectRiskLikelihood => _driver.FindElement(By.XPath("//mat-select[@formcontrolname='likelihoodId']"));
        private IWebElement selectProjectRiskLikelihood => _driver.FindElement(By.XPath("//span[normalize-space()='Low']"));
        private IWebElement enterReasonForClosingRisk=> _driver.FindElement(By.XPath("//textarea[@id ='mat-input-2']"));
        private IWebElement enterProjectRiskDescription => _driver.FindElement(By.XPath("//textarea[@id ='mat-input-3']"));
        private IWebElement enterMitigalPorposal => _driver.FindElement(By.XPath("//textarea[@id ='mat-input-4']"));
        private IWebElement clickSaveButton => _driver.FindElement(By.XPath("//span[normalize-space()='Save']"));





        public void ClickProjectRiskTitle()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickProjectRiskTitle)).Click();

        }
        public void SelectProjectRiskTitle()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectProjectRiskTitle)).Click();

        }
        public void ClickProjectRiskTreatmant()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickProjectRiskTreatmant)).Click();

        }
        public void SelectProjectRiskTreatmant()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectProjectRiskTreatmant)).Click();

        }
        public void ClickProjectRiskImpact()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickProjectRiskImpact)).Click();

        }
        public void SelectProjectRiskImpact()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectProjectRiskImpact)).Click();
        }
        public void ClickProjectRiskLikelihood()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickProjectRiskLikelihood)).Click();

        }
        public void SelectProjectRiskLikelihood()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(selectProjectRiskLikelihood)).Click();
        }

        public void WriteReasonForClosingRisk(string ReasonForClosingRisk)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(enterReasonForClosingRisk)).SendKeys(ReasonForClosingRisk);
        }
        public void WriteProjectRiskDescription(string ProjectRiskDescription)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(enterProjectRiskDescription)).SendKeys(ProjectRiskDescription);
        }
        public void WriteMitigalPorposal(string MitigalPorposal)
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(enterMitigalPorposal)).SendKeys(MitigalPorposal);
        }

        public void ClickSaveButton()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(clickSaveButton)).Click();
        }
    }
}
