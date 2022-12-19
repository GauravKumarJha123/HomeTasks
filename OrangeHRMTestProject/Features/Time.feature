Feature: Time

A short summary of the feature

@Chrome
@TimeSheet
Scenario: Search for Users in TimeSheet
	Given I am Logged in Sucessfully
	When I Click on Time Tab
	And I Fetch User Data
	And I Enter User Name
	And I Click on View Button
	Then I Should Get The Timesheet of Employee
