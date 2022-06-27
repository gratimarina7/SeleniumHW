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
            addNewBusinessObjective.WhriteBusinessObjectiveOutput("One business objective output");

            log.Info("Whrite business obective name!");
            log.Info("Whrite business objective name and output!");
        }

        [When(@"I choose the following data into the new Business Objective form:")]
        public void WhenIChooseTheFollowingDataIntoTheNewBusinessObjectiveForm(Table table)
        {
            AddNewBusinessObjective addNewBusinessObjective = new AddNewBusinessObjective(driver, wait);
            addNewBusinessObjective.ClickStatusField();
            addNewBusinessObjective.SelectStatusInput();
            addNewBusinessObjective.ClickPriorityInput();
            addNewBusinessObjective.SelectPriorityInput();
            addNewBusinessObjective.ClickOnCalendar();
            addNewBusinessObjective.SelectDeadlineMonth();
            addNewBusinessObjective.SelectDeadlineDate();

            log.Info("Clicked status field!");
            log.Info("Selected status!");
            log.Info("Clicked priority field!");
            log.Info("Selected priority!");
            log.Info("Click on calendar!");
            log.Info("Select Deadline Month!");
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
            cancelAddNewBusinessObjective.WhriteBusinessObjectiveOutput("Second business objective output");

            log.Info("Whrite business obective name!");
            log.Info("Whrite business objective name and output!");
        }
        [When(@"I choose the following data into the Business Objective form:")]
        public void WhenIChoseTheFollowingDataIntoTheBusinessObjectiveForm(Table table)
        {
            CancelAddNewBusinessObjective cancelAddNewBusinessObjective = new CancelAddNewBusinessObjective(driver, wait);
            cancelAddNewBusinessObjective.ClickStatusField();
            cancelAddNewBusinessObjective.SelectStatusInput();
            cancelAddNewBusinessObjective.ClickPriorityInput();
            cancelAddNewBusinessObjective.SelectPriorityInput();
            cancelAddNewBusinessObjective.ClickOnCalendar();
            cancelAddNewBusinessObjective.SelectDeadlineMonth();
            cancelAddNewBusinessObjective.SelectDeadlineDate();

            log.Info("Click status field!");
            log.Info("Select status!");
            log.Info("Click priority field!");
            log.Info("Select priority!");
            log.Info("Click on calendar!");
            log.Info("Select Deadline Month!");
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
            editBusinessObjective.EditBusinessObjectiveOutput("Edit the first business objective output");
           
             log.Info("Edit first business objectives!");
             log.Info("Edit first business objectives output!");
        }
        [When(@"I choose the following data into the edited Business Objective form:")]
        public void WhenIChooseTheFollowingDataIntoTheEditedBusinessObjectiveForm(Table table)
        {
            EditBusinessObjective editBusinessObjective = new EditBusinessObjective(driver, wait);
            editBusinessObjective.ClickStatusInput();
            editBusinessObjective.SelectStatusInput();
            editBusinessObjective.ClickPriorityInput();
            editBusinessObjective.SelectPriorityInput();
            editBusinessObjective.ClickOnCalendar();
            editBusinessObjective.SelectDeadlineMonth();
            editBusinessObjective.SelectDeadlineDate();

            log.Info("Click status field!");
            log.Info("Select status!");
            log.Info("Click priority field!");
            log.Info("Select priority!");
            log.Info("Click on calendar!");
            log.Info("Select Deadline Month!");
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
            editBusinessObjective.EditBusinessObjectiveOutput("Make some changes into business objective output");

            log.Info("Edit business objectives!");
            log.Info("Edit business objectives output!");
        }
        [When(@"I choose the following data into Edited Business Objective form:")]
        public void WhenIChooseTheFollowingDataIntoEditedBusinessObjectiveForm(Table table)
        {
            EditBusinessObjective editBusinessObjective = new EditBusinessObjective(driver, wait);
            editBusinessObjective.ClickStatusInput();
            editBusinessObjective.SelectStatusInput2();
            editBusinessObjective.ClickPriorityInput();
            editBusinessObjective.SelectPriorityInput2();
            editBusinessObjective.ClickOnCalendar();
            editBusinessObjective.SelectDeadlineMonth();
            editBusinessObjective.SelectDeadlineDate2();

            log.Info("Click status input!");
            log.Info("Select status input 2!");
            log.Info("Click priority input!");
            log.Info("Select priority input 2!");
            log.Info("Click on calendar!");
            log.Info("Select Deadline Month!");
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
