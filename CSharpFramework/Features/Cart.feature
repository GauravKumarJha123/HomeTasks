﻿Feature: 03. Cart Execution Order = 3

Verifying The Cart Page

@Cart
Scenario: Verifying whether items are Added To cart or not
	Given I am logged in Sucessfully
	And I have Added Items To Cart
	When  I Navigate To Cart Page
	Then I See My List Of Products
