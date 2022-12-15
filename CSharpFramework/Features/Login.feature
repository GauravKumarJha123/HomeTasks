@Chrome
@Login

Feature: 01. LoginScenarios 

Verify Login Functionality Of Sauce Demo Website

Background:user is already on the correct page
 Given a user is on the base page



Scenario Outline: 01. Trying With Valid Credentials
	When I Enter Valid Credentials '<UserName>'
	And  I Enter Password 'secret_sauce'
	And I Click on Login Button
	Then I Navigate to Inventory Page Url
Examples: 
| UserName                |
| standard_user           |
| locked_out_user         |
| performance_glitch_user |
| problem_user            |
	


