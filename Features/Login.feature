Feature: User Login
To Test Login
Rule: Valid credentials will result in successful login and invalid one in unsuccessful login
Background: 
    Given I am on the login page
Scenario: Successful login
	When I give valid credentials
	Then I should see a success message
Scenario: Unsuccessful login
	When I give invalid credentials
	Then I should see an error message