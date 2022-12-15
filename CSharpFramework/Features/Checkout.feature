Feature: 04. Checkout 

Verfying Checkout Feature Page

@Checkout
Scenario: Checkout as Valid User
	Given I am logged in Sucessfully
	And I have Added Items To Cart
	And I Navigate To Cart Page and Click on Checkout Button
	And I Enter FirstName as 'Gaurav'
	And I Enter LastName as 'Jha'
	And I Enter ZipCode as '110001'
	And I Click on Continue Button
	Then Checkout is Intiated
	When I Click on Finish Button
	Then Checkout Process is completed
