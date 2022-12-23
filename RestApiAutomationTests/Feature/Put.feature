Feature: Put


Scenario Outline: Update The Existing Fields
	Given I Update a Post using id <id> title '<title>' and author '<author>'
	Then I Should be able to get the post with id <id> title '<title>' and author '<author>'
	Examples: 
	| id	| title					| author			     |
	|  2		|  ASD | CVB  |