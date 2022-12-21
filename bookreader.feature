Feature: bookreader

A short summary of the feature

@tag1
Scenario: Scenario
	Given I am on the homepage
	When I click the website link
	And Once I am there I click the read more button
	And browse down the page and then click the purchase Testing Web APIs Now button
	Then  it is navigating to testing web APIs

@tag1
Scenario: code
	Given I am on the homepage
	And I click the code link
	Then it is navigating to github website

@tag1
Scenario: Attend AIT Training
	Given I am on homepage
	When I click the AIT training link
	And it shows some information about public training and clicks the training button
	And after moving to the previous page it clicks on online courses button
	And after moving to the previous page it clicks on blog button
	Then it navigates to the home page
	