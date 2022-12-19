Feature: Recruitment

A short summary of the feature

@Recruitment
@Chrome
Scenario: 01. Add A Candidate
	Given I am Logged in Sucessfully
	When I Click on Recruitment Tab
	And I Click on Add Button
	And I Enter First Name
	And I Enter Last Name
	And I Enter EmailId
	And I Click on Save Button
	And I Verify the Names

@Recruitment01
@Chrome
Scenario: 02. Verify Last Name Requirement
	Given I am Logged in Sucessfully
	When I Click on Recruitment Tab
	And I Click on Add Button
	And I Enter First Name
	And I Enter EmailId
	And I Click on Save Button
	And I Verify the Result
