Feature: 01. Login Feature
   I want to log into the website

@Chrome
@Login
Scenario: Successful Login with Valid Credentials
	Given User is at the Login Page
	When User enter credentials 'Admin' and 'admin123'
	And Click on the LogIn button
	Then Successful LogIN message should display