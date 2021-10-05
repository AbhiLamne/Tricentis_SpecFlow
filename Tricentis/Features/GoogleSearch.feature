Feature: GoogleSearch
	

@Chrome
Scenario: Google search for Tricentis
	Given I have navigated to Google website
	And I have entered Tricentis as search keyword
	When I press the search button
	Then I should be navigate to search results page
		