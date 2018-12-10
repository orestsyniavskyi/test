Feature: Add a story
	In order to create a story
	As a certain customer
	I want to be able to see it in a story list

@setupBrowser	@quitBrowser	@LogIn
Scenario: Create story
	Given I press create button and choose story
	And Fill in boxes with data from the table and press Save&Close
	| StoryName | StoryDescription | ProgramName                              |
	| test      | doubletest       | Backlog.Portfolio.NoCapabilities.PROGRAM |
	When I check the story list
	Then Appropriate story must be presented
