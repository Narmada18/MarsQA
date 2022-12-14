 Feature:  Profile

As a admin of skill swap page
I would like to edit,update and delete profile

@tag1
Scenario:Update Profile with valid details
	Given I logged into marsQA successfully
    When I navigate to Profile page
	And I update my details
	Then The details updated successfully


	Scenario: Adding languages to the page
	Given I enterd all the details 
	When I clicked on add new button
	Then details added successfully


	Scenario: Adding skills to the page
	Given I entered all the skills
	When I clicked on add new
	Then Skills updated successfully

	
	Scenario: Adding valid education details
	Given I entered all the details
	When I clicked add new button
	Then details added successfully


