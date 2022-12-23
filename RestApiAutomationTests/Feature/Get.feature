Feature: Get

Scenario Outline: Get a new Post
	Given I Create a new Post using id <id> title '<title>' and author '<author>'
	Then I get the post the post with id <id> title '<title>' and author '<author>'
Examples:
	| id | title | author |
	| 10 | xyz   | abc    |

