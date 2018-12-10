@setupBrowser @quitBrowser 
Feature: Check Logging In 
	In order to use AgileCraft functionality
	As a certain user
	I want to be able to log in the system

Scenario: Logging In
	Given I have opened the AgileCraft web-site		
	When I have logined in with proper credentials
	Then the Home Page is opened
