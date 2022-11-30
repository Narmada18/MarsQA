 Feature:  Profile

As a admin of skill swap page
I would like to edit,update and delete profile

@tag1
Scenario:Update Profile with valid details
	Given I logged into marsQA successfully
	When I navigate to Profile page
	And I update my details
	Then The details updated successfully
