Feature: AP_CreateAccount
In order to be able to buy items
As non-user of the automation practice website 
I want to be able to create an account
So that I can start buying fake goods

	@createaccount
Scenario: Creating account with Invalid e-mail

	Given I am on the login page
	When I enter the email 'testmail.com'
	And Click Create Account
	Then I should see an alert containing the error message "Invalid email address".

	@createaccount
Scenario: Creating account with valid e-mail

	Given I am on the login page
	When I enter the email 'nish@testmail.com'
	And Click Create Account
	Then I should land on the on page which contains with the Url "http://automationpractice.com/index.php?controller=authentication#account-creation".