Feature: Leave

A short summary of the feature

@Chrome
@Leave
Scenario: Search for Leave Users
	Given I am Logged in Sucessfully
	When I Click on Leave Tab
	And I Fetch Leave Date
	And I Enter Leave Date
	And I Click on SearchButton
	Then I get the User
