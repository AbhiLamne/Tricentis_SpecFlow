Feature: EmployeeDetails
	


@EmployeeDetailsTest
Scenario: Create a new employee with amndatory details

	Given I have opened the application
	Then I should see employee details page
	When I fill all the mandatory details in form

	| Name		| Age| Phone	  | Email		   |
	| Abhishek	| 28 | 9988776655 | abhilamne@1234 |
	| Pradnya	| 27 | 9988776654 | abhilamne@1235 |
	| Vaishu	| 24 | 9988776653 | abhilamne@1236 |
	| Teju		| 20 | 9988776652 | abhilamne@1237 |

	And I click the save button
	Then I should see all the details saved in my application and DB



#Scenario Outline: Create a new employee with amndatory details for different Employees
#	Given I have opened the application
#	Then I should see employee details page
#	When I fill all the mandatory details in form <Name>, <Age>, <Phone> and <Email>
#	And I click the save button
#	Then I should see all the details saved in my application and DB
#	Examples: 
#		| Name | Age | Phone | Email |
#		| Abhishek | 28 | 9988776655 | abhilamne@1234 |
#		| Pradnya  | 27 | 9988776654 | abhilamne@1235 |
#		| Vaishu   | 24 | 9988776653 | abhilamne@1236 |
#		| Teju     | 20 | 9988776652 | abhilamne@1237 |


Scenario: If I could get the details entered via Teble from Extended Steps
	When I fill all the mandatory details in form
	| Name    | Age | Phone      | Email        |
	| Prithvi | 45  | 8747376809 | jfhkjdsf@com |
	Then I should get the same value from Extended Steps