@Chrome
Feature: Inventory

Verifying whether items are added to the cart

Scenario: Adding Inventory items to Cart
	Given a user is on the base page
	And   I Logged in Sucessfully
	When  I Added Items to Cart
	Then  Item are added to the cart
