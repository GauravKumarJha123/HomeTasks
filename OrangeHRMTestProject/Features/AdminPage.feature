
Feature: 02. Admin Page Feature

@Admin
@Chrome
Scenario: 01. Add Users To the Record
	Given I am Logged in Sucessfully
	When I Click on Admin Tab
	And I Click on Add Button
	And I Select User Role
	And I Select User Status
	And I Select Employee Name
	And I Select User Name
	And I Select User Password
	And I Enter Password Again
	And I Click on Save Button
	Then User is Added

@Admin01
@Chrome
Scenario: 02. Verifying User Records
	Given I am Logged in Sucessfully
	When I Click on Admin Tab
	And I Fetch The records
	And I Enter User Details in Search Fields
	And I cllick on Search Button
	Then I Should Get the Users Value