Feature: Tricentis_SpecFlow
	

@Chrome
Scenario: Open Tricentis site and fill up the form
	Given I have navigated to the Tricentis website
	When I fill all the details in the form
	Then I should get the successful result