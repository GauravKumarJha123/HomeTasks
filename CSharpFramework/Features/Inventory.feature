@Chrome
@Inventory
Feature: 02. Inventory 

Verifying whether items are added to the cart

Scenario: Adding Inventory items to Cart
	Given I am Logged in With Valid Credentials
	And I Navigated to Inventory Page
	When   I Added Items To Cart
	And I Click on Cart Button
	Then  Items are added to the cart
	And I NAvigate ot Cart Page
