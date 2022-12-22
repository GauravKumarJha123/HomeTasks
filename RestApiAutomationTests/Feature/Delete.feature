Feature: Delete


Scenario Outline: Delete a new Post
	Given I Create a new Post using id <id> title '<title'> and author '<author>'
	Then I Delete the post the post with id <id> title '<title'> and author '<author>'
	Examples: 
	| id	| title					| author			     |
	|  2		| AutoBiography of Yogi | Paramahansa Yogananda  |
