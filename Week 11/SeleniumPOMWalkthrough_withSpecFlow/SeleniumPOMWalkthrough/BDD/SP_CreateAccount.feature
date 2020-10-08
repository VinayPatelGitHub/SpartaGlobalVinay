Feature: SP_CreateAccount
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@CreateNewAccount
Scenario: Valid Email
Given I am on the signin page 
And I have entered the correct email 'testing@snailmail.ccm' into Create Account
When I click the Create Account sign in button 
Then I should see 
Examples:
|passwords|
|four     |
|1234     |
|Nish     |

@CreateNewAccount
Scenario: Invalid Email
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120