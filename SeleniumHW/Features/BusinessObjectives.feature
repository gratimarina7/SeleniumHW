Feature: Business Objectives Feature
In order to test create, edit, delete, search functionality on https://projectplanappweb-stage.azurewebsites.net/
As a developer
I want to ensure functionality is working end to end
 
 Background: 
 Given I logged in successfully
 And I am on Business Objectives Page

@positive
Scenario: 1 Create New Business Objective

	When I clicked Add Business Objective 
	And I entered the following data into the new Business Objective form:
    |Enter a business objective    | Enter a business objective output |
    |One business objective        | One business objective output     |
	And I choose the following data into the new Business Objective form:
	| Status      | Piority | Deadline   |
	| Not Started | Low     | 16/06/2022 |
	And I clicked submit button
	Then A pop up message Business Objective added successfully is displayed


@negative
Scenario: 3 Cancel creating a new Business Objective

	When I clicked Add New Business Objective 
	And I entered the following data into the Business Objective form:
    | Enter a business objective | Enter a business objective output |
    | Second business objective  | Second business objective output  |    
	And I choose the following data into the new Business Objective form:
	| Status      | Piority | Deadline   |
	| In progress | High    | 30/06/2022 |
	Then I clicked Cancel button the new business objective was not saved

@positive
Scenario: 2 Search business objective by the Name
	When I click on Search input field
	And I have entered One business objective as search keyword
    And I click the search button
    Then I should see all business objectives with this name

	
@positive
Scenario: 4 Edit Business Objective
    When I delete status filter
	And I clicked on Edit Business Objective button 
	And I changed the following data into the Business Objective form:
    | Enter a business objective        | Enter a business objective output        |
    | Edit the first business objective | Edit the first business objective output |  
	And I choose the following data into the new Business Objective form:
	| Status  | Piority | Deadline   |
	| Stopped | High    | 26/06/2022 |
	And I clicked Save button
	Then A pop up message Business Objective updated successfully is displayed

@negative
Scenario: 5 Cancel editing Business Objective
    When I clicked Edit Business Objective
	And I changed the following data into Edited Business Objective form:
    | Enter a business objective                | Enter a business objective output                |
    | Make some changes into business objective | Make some changes into business objective output |    
	And I choose the following data into Edited Business Objective form:
	| Status   | Piority | Deadline   |
	| Achieved | High    | 28/06/2022 |
	Then I clicked Cancel the edited business objective was not saved

@negative 
Scenario: 6 Cancel deleting Business Objective
	When I clicked on Delete Business Objective
	Then I clicked No button from the Confirmation modal box and the business objective was not deleted

@positive 
Scenario: 8 Delete Business Objective
	When I clicked on Delete Business Objective button
	And I clicked Yes from the Confirmation modal box
	Then A pop up message Business Objective deleted successfully is displayed and business objective was deleted


@positive
Scenario: 7 Filter business objectives by the Status
	When I clicked on delete button of status filter
	And I click to expand Filter status field
	And I select Achieved field
    Then I should see all business objectives with Achieved status
