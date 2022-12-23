Feature: Patch


Scenario Outline: Update a Request
	Given I Create a new Post 
	Then I Update the post using Patch entering '<title>'
	Examples: 
	| title					 | 
	|  AutoBiography of Yogi |
