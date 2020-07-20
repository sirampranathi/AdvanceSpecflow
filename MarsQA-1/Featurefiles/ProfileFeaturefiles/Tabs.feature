Feature: Tabs
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Language
Scenario: Add new language
	Given Click on Language tab
	And Click on addnew button
	When Enter new language details
	Then verify new language is added

	Scenario: Edit existing language
	Given Click on edit button
	When Update  language details
	Then Verify record updated

    Scenario: Delete existing language
	Given Click on delete button
	Then Verify record is deleted

	@Skills
	Scenario: Add new Skill record
	Given Click on Skill tab in profile
	And Click on addnew skill record
	When Enter new Skills details and click add
	Then Verify new skill record is added

Scenario: Edit existing Skill details
	Given Click on edit Skill button
	When  Update Skill and click update
	Then Verify skill is updated

Scenario: Delete existing Skill details
	Given Click on delete Skill button
	Then Verify skill is deleted

@Education
	Scenario: Add new Education record
	Given Click on Education tab in profile
	And Click on addnew Education record
	When Enter new Education details and click add
	Then Verify new Education record is added

Scenario: Edit existing Education details
	Given Click on edit Education button
	When  Update Education and click update
	Then Verify Education is updated

Scenario: Delete existing Education details
	Given Click on delete Education button
	Then Verify Education is deleted


