Feature: Profiledetails
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Auto1
Scenario: Enter User Description 
	Given  Click on Description edit button
	When User enter the text in description box
	Then Click save and the text is saved
@Auto2
Scenario: Enter Username  
	Given   Click on name dropdown
	When  Enter Firstname and lastname
	Then Click on save and name is added
@Auto3
Scenario: Enter user Availability
    Given Click Availabilty details
	When select the available timings
    Then Availabity is  added
@Auto4
Scenario: Enter Hours needed
    Given Click Hours details
	When select hours needed
    Then Hours needed are  added
@Auto5
Scenario: Enter Target amount 
    Given Click Earn Target details
	When  select target amount 
    Then  Target amount is added  

Scenario: Search for the particular Skill
    Given Click on searchlink button
    And  Select Catogery 
	When Select SubCategory
    When Select filter in searchpage 
	Then Select the record
	



