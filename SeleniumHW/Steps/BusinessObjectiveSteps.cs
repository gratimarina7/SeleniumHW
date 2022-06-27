using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Framework_Marina.PageObjectModel;
using Framework_Marina.Hooks;

namespace Framework_Marina.Features
{
    [Binding]
    public class BusinessObjectivesSteps : FrameworkConfigurator
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [Given(@"I logged in successfully")]
        public void GivenILoggedInSuccessfully()
        {
            LogInPage logInPage = new LogInPage(driver, wait);
            logInPage.ClickLoginButton();

            EmailPage emailPage = new EmailPage(driver, wait, customWait);
            emailPage.WriteEmail("marina.grati@amdaris.com");
            emailPage.PressNextButton();

            PasswordPage passwordPage = new PasswordPage(driver, wait, customWait);
            passwordPage.WritePassword("Test12341!");
            passwordPage.PressSignInButton();

            SignInPage signIn = new SignInPage(driver, wait);
            signIn.TickCheckbox();
            signIn.PressYesnButton();

            log.Info("Successfully logged in!");
        }

        [Given(@"I am on Business Objectives Page")]
        public void GivenIAmOnBusinessObjectivesPage()
        {
            DashboardPage selectProjectPage = new DashboardPage(driver, wait);
            selectProjectPage.ClickProjectsButton();

            ProjectsPage selectBusinessObjectives = new ProjectsPage(driver, wait);
            selectBusinessObjectives.SelectBusinessObjectives();

            log.Info("Successfully accessed to Business Objective Page!");
        }

        [When(@"I clicked Add Business Objective")]
        public void WhenIClickedAddBusinessObjective()
        {
            BusinessObjectivesPage addNewBusinessObjectives = new BusinessObjectivesPage(driver, wait);
            addNewBusinessObjectives.ClickAddBusinessObjective();

            log.Info("Clicked on Add Business Objective!");
        }

        [When(@"I entered the following data into the new Business Objective form:")]
        public void WhenEnteredTheFollowingDataIntoTheNewBusinessObjectiveform(Table table)
        {
            AddNewBusinessObjective addNewBusinessObjective = new AddNewBusinessObjective(driver, wait);
            addNewBusinessObjective.WhriteBusinessObjective("One business objective");
            log.Info("Write business obective name!");
            addNewBusinessObjective.WhriteBusinessObjectiveOutput("One business objective output");
            log.Info("Write business objective name and output!");
        }

        [When(@"I choose the following data into the new Business Objective form:")]
        public void WhenIChooseTheFollowingDataIntoTheNewBusinessObjectiveForm(Table table)
        {
            AddNewBusinessObjective addNewBusinessObjective = new AddNewBusinessObjective(driver, wait);
            addNewBusinessObjective.ClickStatusField();
            log.Info("Clicked status field!");
            addNewBusinessObjective.SelectStatusInput();
            log.Info("Selected status!");
            addNewBusinessObjective.ClickPriorityInput();
            log.Info("Clicked priority field!");
            addNewBusinessObjective.SelectPriorityInput();
            log.Info("Selected priority!");
            addNewBusinessObjective.ClickOnCalendar();
            log.Info("Click on calendar!");
            addNewBusinessObjective.SelectDeadlineMonth();
            log.Info("Select Deadline Month!");
            addNewBusinessObjective.SelectDeadlineDate();
            log.Info("Select DeadLine Date!");
        }
       
        [When(@"I clicked submit button")]
        public void WhenIClickedSubmitButton()
        {
            AddNewBusinessObjective addNewBusinessObjective = new AddNewBusinessObjective(driver, wait);
            addNewBusinessObjective.SaveNewBusinessObjective();
            log.Info("Clicked submit button!");
        }

        [Then(@"A pop up message Business Objective added successfully is displayed")]
        public void ThenAPopUpMessageBusinessObjectiveAddedSuccessfullyIsDisplayed()
        {
            BusinessObjectivesPage messageNewBusinessObjectives = new BusinessObjectivesPage(driver, wait);
            messageNewBusinessObjectives.MessageBusinessObjectiveSave();
            log.Info("Pop Up Business Objective added successfully displayed!");
        }

        [When(@"I clicked Add New Business Objective")]
        public void WhenIClickedAddNewBusinessObjective()
        {
            BusinessObjectivesPage addNewBusinessObjectives = new BusinessObjectivesPage(driver, wait);
            addNewBusinessObjectives.ClickAddBusinessObjective();
            log.Info("Clicked on Add New Business Objective!");
        }

        [When(@"I entered the following data into the Business Objective form:")]
        public void WhenIEnteredTheFollowingDataIntoTheBusinessObjectiveForm(Table table)
        {
            CancelAddNewBusinessObjective cancelAddNewBusinessObjective = new CancelAddNewBusinessObjective(driver, wait);
            cancelAddNewBusinessObjective.WhriteBusinessObjective("Second business objective");
            log.Info("Write business obective name!");
            cancelAddNewBusinessObjective.WhriteBusinessObjectiveOutput("Second business objective output");
            log.Info("Write business objective name and output!");
        }
        [When(@"I choose the following data into the Business Objective form:")]
        public void WhenIChoseTheFollowingDataIntoTheBusinessObjectiveForm(Table table)
        {
            CancelAddNewBusinessObjective cancelAddNewBusinessObjective = new CancelAddNewBusinessObjective(driver, wait);
            cancelAddNewBusinessObjective.ClickStatusField();
            log.Info("Click status field!");
            cancelAddNewBusinessObjective.SelectStatusInput();
            log.Info("Select status!");
            cancelAddNewBusinessObjective.ClickPriorityInput();
            log.Info("Click priority field!");
            cancelAddNewBusinessObjective.SelectPriorityInput();
            log.Info("Select priority!");
            cancelAddNewBusinessObjective.ClickOnCalendar();
            log.Info("Click on calendar!");
            cancelAddNewBusinessObjective.SelectDeadlineMonth();
            log.Info("Select Deadline Month!");
            cancelAddNewBusinessObjective.SelectDeadlineDate();
            log.Info("Select DeadLine Date!");   
        }
        [Then(@"I clicked Cancel button the new business objective was not saved")]
        public void ThenIClickedCancelButtonTheNewBusinessObjectiveWasNotSaved()
        {
            CancelAddNewBusinessObjective cancelAddNewBusinessObjective = new CancelAddNewBusinessObjective(driver, wait);
            cancelAddNewBusinessObjective.CancelToSaveNewBusinessObjective();
            log.Info("Clicked cancel button!");
        }

        [When(@"I click on Search input field")]
        public void WhenIClickOnSearchInputField()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ClickOnSearchInputField("One business objective");
            log.Info("Clicked on Search!");
        }

        [When(@"I have entered One business objective as search keyword")]
        public void IHaveEnteredOneBusinessObjectiveAsSearchKeyword()
        {
           BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
           businessObjectivePage.WriteInSearchInputField("One business objective");
           log.Info("Write One Business Objective!");
        }

        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ClickOnSearchButton();
            log.Info("Clicked on Search button!");
        }

        [Then(@"I should see all business objectives with this name")]
        public void ThenIShouldSeeAllBusinessObjectivesWithThisName()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ClickOnSearchButton();
            log.Info("Clicked on search button!");
        }
        [When(@"I delete status filter")]
        public void WhenIDeleteStatusFilter()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ClickDeleteStatusFilter();
            log.Info("Delete status filter!");
        }
        [When(@"I clicked on Edit Business Objective button")]
        public void WhenIClickedOnEditBusinessObjectiveButton()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ClickEditBusinessObjective();
            log.Info("Click on edit business objectives button!");
        }
        
        [When(@"I changed the following data into the Business Objective form:")]
        public void WhenIChangedTheFollowingDataIntoTheBusinessObjectiveForm(Table table)
        {
            EditBusinessObjective editBusinessObjective = new EditBusinessObjective(driver, wait);
            editBusinessObjective.EditBusinessObjectives("Edit the first business objective");
            log.Info("Edit business objectives!");
            editBusinessObjective.EditBusinessObjectiveOutput("Edit the first business objective output");
            log.Info("Edit business objectives output!");
        }
        [When(@"I choose the following data into the edited Business Objective form:")]
        public void WhenIChooseTheFollowingDataIntoTheEditedBusinessObjectiveForm(Table table)
        {
            EditBusinessObjective editBusinessObjective = new EditBusinessObjective(driver, wait);
            editBusinessObjective.ClickStatusInput();
            log.Info("Click status field!");
            editBusinessObjective.SelectStatusInput();
            log.Info("Select status!");
            editBusinessObjective.ClickPriorityInput();
            log.Info("Click priority field!");
            editBusinessObjective.SelectPriorityInput();
            log.Info("Select priority!");
            editBusinessObjective.ClickOnCalendar();
            log.Info("Click on calendar!");
            editBusinessObjective.SelectDeadlineMonth();
            log.Info("Select Deadline Month!");
            editBusinessObjective.SelectDeadlineDate();
            log.Info("Select DeadLine Date!");
        }
        [When(@"I clicked Save button")]
        public void WhenIClickedEditedSaveButton()
        {
            EditBusinessObjective editBusinessObjective = new EditBusinessObjective(driver, wait);
            editBusinessObjective.SaveEditedBusinessObjective();
            log.Info("Clicked save button!");
        }
        [Then(@"A pop up message Business Objective updated successfully is displayed")]
        public void ThenAPopUpMessageBusinessObjectiveUpdatedSuccessfullyIsDisplayed()
        {
            BusinessObjectivesPage messageUpdatedEditedBusinessObjectives = new BusinessObjectivesPage(driver, wait);
            messageUpdatedEditedBusinessObjectives.MessageBusinessObjectiveEditedSave();
            log.Info("Pop Up Business Objective updated successfully is displayed!");
        }
        [When(@"I clicked Edit Business Objective")]
        public void WhenIClickEditBusinessObjective()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ClickEditBusinessObjective();
            log.Info("Click edit business objectives");
        }

        [When(@"I changed the following data into Edited Business Objective form:")]
        public void WhenIChangedTheFollowingDataIntoEditedBusinessObjectiveForm(Table table)
        {
            EditBusinessObjective editBusinessObjective = new EditBusinessObjective(driver, wait);
            editBusinessObjective.EditBusinessObjectives("Make some changes into business objective");
            log.Info("Edit business objectives!");
            editBusinessObjective.EditBusinessObjectiveOutput("Make some changes into business objective output");
            log.Info("Edit business objectives output!");
        }
        [When(@"I choose the following data into Edited Business Objective form:")]
        public void WhenIChooseTheFollowingDataIntoEditedBusinessObjectiveForm(Table table)
        {
            EditBusinessObjective editBusinessObjective = new EditBusinessObjective(driver, wait);
            editBusinessObjective.ClickStatusInput();
            log.Info("Click status input!");
            editBusinessObjective.SelectStatusInput2();
            log.Info("Select status input 2!");
            editBusinessObjective.ClickPriorityInput();
            log.Info("Click priority input!");
            editBusinessObjective.SelectPriorityInput2();
            log.Info("Select priority input 2!");
            editBusinessObjective.ClickOnCalendar();
            log.Info("Click on calendar!");
            editBusinessObjective.SelectDeadlineMonth();
            log.Info("Select Deadline Month!");
            editBusinessObjective.SelectDeadlineDate2();
            log.Info("Select DeadLine Date 2!");
        }
        [Then(@"I clicked Cancel the edited business objective was not saved")]
        public void ThenIClickedCancelTheEditedBusinessObjectiveWasNotSaved()
        {
            EditBusinessObjective editBusinessObjective = new EditBusinessObjective(driver, wait);
            editBusinessObjective.CancelEditedBusinessObjective();
            log.Info("Clicked cancel button!");
        }
        [When(@"I clicked on Delete Business Objective")]
        public void WhenIClickedOnDeleteBusinessObjective()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ClickDeleteBusinessObjectiveButton();
            log.Info("Click delete business objective button!");
        }
        [Then(@"I clicked No button from the Confirmation modal box and the business objective was not deleted")]
        public void ThenIClickedNoButton()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ClickCancelDeleteBusinessObjectiveButton();
            log.Info("Click cancel to delete business obectives!");
        }
        [When(@"I clicked on Delete Business Objective button")]
        public void WhenIClickedOnDeleteBusinessObjectiveButton()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ClickDeleteBusinessObjectiveButton();
            log.Info("Click Delete button!");
        }
        [When(@"I clicked Yes from the Confirmation modal box")]
        public void WhenIClickedYesToDeleteBusinessObjective()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ClickConfirmationToDeleteBusinessObjectiveButton();
            log.Info("Click confirmation to delete!");
        }
        [Then(@"A pop up message Business Objective deleted successfully is displayed and business objective was deleted")]
        public void ThenIClickedYesButton()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.MessageBusinessObjectiveDeleted();
            log.Info("Pop Up Business Objective deleted successfully is displayed!!");
        }
        [When(@"I clicked on delete button of status filter")]
        public void WhenIClickedOnDeleteButtonOfStatusFilter()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ClickDeleteStatusFilter();
            log.Info("Click delete status filter!");
        }
        [When(@"I click to expand Filter status field")]
        public void WhenIClickedToExpandStatusFilter()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.ExpandStatusFilterPositions();
            log.Info("Expand status filter position!");
        }
        [When(@"I select Achieved field")]
        public void WhenISelectAchievedField()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.SelectStatusFilterPosition();
            log.Info("Select status filter position");
        }
        [Then(@"I should see all business objectives with Achieved status")]
        public void WhenIShouldSeeAllBusinessObjectivesWithAchievedStatus()
        {
            BusinessObjectivesPage businessObjectivePage = new BusinessObjectivesPage(driver, wait);
            businessObjectivePage.SelectStatusFilterPosition();
            log.Info("View all selected status filter positions!");
        }
    }
}
