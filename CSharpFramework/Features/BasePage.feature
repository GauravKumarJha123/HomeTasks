@Chrome
Feature: BaseScenarios



Background:user is On HomePage
 Given a user is on the base page

Scenario: 01. Validate the title of a website
 Then they see the page title contains "Swag Labs"

Scenario: 02. Validate the URL of a web page
 Then the page URL contains "https://www.saucedemo.com/"

Scenario: 03. Validate the PageSource string on a web page
 Then they see "standard_user" in the PageSource

Scenario: 04. Validate the PageSource contains multiple text
 Then they see
  | expectedText  |
  | standard_user    |
  | problem_user |
  | locked_out_user   |