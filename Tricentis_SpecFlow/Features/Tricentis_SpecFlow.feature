Feature: Tricentis_SpecFlow
	Open the Tricentis website and fill up the form for Camper

@tag1
Scenario Outline: Open Tricentis website and fill up the form for Camper
	Given I have navigated to the Tricentis website
	When I clicked on Camper
	Then I see Enter Vehicle Data page is opened
	When I select a data from dropdown for Make field as Audi
	When I select a data from dropdown for Engine Performance field as 1000
	When I select a date for Date Of Manufacture field as 10 April 2018
	When I select a data from dropdown for Number of Seats field as 9
	When I click on Radio Button for Right Hand Drive field as 'Yes'
	When I select a data from dropdown for Fuel Type field as Gas
	When I enter a data for Payload field as 800
	When I enter a data for Total Weight field as 1000
	When I enter a data for List Price field as 100000
	When I enter a data for License Plate Number field as MH12
	When I enter a data for Annual Mileage field as 4000
	When I click on Next Button1
	Then I see the Enter Insurance Data page is opened

Scenario Outline: Open Enter Insurance Data page and Fill-up the page
	Given I opened the Tricentis website and navigated to Enter Insurance Data page
	When I enter a data for First Name field as John
	When I enter a data for Last Name field as Smith
	When I select a date for Date of Birth field as 31 January 2003
	When I click on Radio Button for Gender as 'Female'
	When I enter a data for Street Address field as FC road
	When I select a data from dropdown for Country field as Austria
	When I enter a data for Zip code field as 411038
	When I enter a data for City field as Pune
	When I select a data from dropdown for Occupation field as Farmer
	When I click on checkbox for Hobbies field as 'BungeeJumping'
	When I enter a data for Website field as www.amazon.com
	#When I select a file for Picture field as C:\Users\Abhishek Lamne\Desktop\New Bitmap Image.bmp
	When I click on Next Button2
	Then I see the Enter Product Data page is opened

Scenario Outline: Open Enter Product Data page and Fill-up the page
	Given I opened the Tricentis website and navigated to Enter Product Data page
	When I select a date for Start Date field as 14 February 2023
	When I select a data for Insurance Sum as 15000000
	When I select a data for Damage Insurance as No Coverage
	When I click on checkbox for Optional Products field as 'LegalDefenseInsurance'
	When I click on Next Button3
	Then I see the Select Price Option page is opened

	When I click on Radio Button for Select Option field as 'Gold'
	When I click on Next Button4
	Then I see the Send Quote page is opened


#Scenario Outline: Enter user details in Send Quote page
	When I enter a data for E-Mail field as <Email>
	When I enter a data for Phone field as <Phone>
	When I enter a data for Username field as <Username>
	When I enter a data for Password field as <Password>
	When I enter a data for Confirm Password field as <Confirm Password>
	When I enter a data for Comments field as <Comments>
	When I click on Next Button5
	Then I see Sending e-mail success
	Examples: 
	| Email                       | Phone      | Username | Password | Confirm Password | Comments          |
	| abhishek.lamne@Dataction.in | 9988776655 | abhi123  | Abhi@123 | Abhi@123         | Hello! Thank You! |


	#When I enter data for user details from table
	#| Email                       | Phone      | Username | Password | Confirm Password | Comments         |
	#| abhishek.lamne@Dataction.in | 9988776655 | abhi123  | Abhi@123 | Abhi@123         | Hello!Thank You! |
	#When I click on Next Button5
	#Then I see Sending e-mail success
	