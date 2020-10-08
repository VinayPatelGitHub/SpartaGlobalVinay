Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Addition
	Given I have entered 2 into the calculator
	And then I enter 5 into the calculator
	When I press add
	Then as the result of adding the screen should show 7

	
@mytag
Scenario: Subtract
	Given I have entered <input1> into the calculator
	And then I enter <input2> into the calculator
	When I press subtract
	Then as the result of subtracting the screen should show <result>

	Examples: 
	| input1 | input2 | result |
	|1       |1       |0       |
	|2       |1       |1       |
	|3       |2       |1       |

	@mytag
Scenario: SumOfNumbersDivisibleBy2
    Given I have entered the numbers below to a list
    | nums |
    | 1    |
    | 2    |
    | 3    |
    | 4    |
    | 5    |
    When I iterate through the list, selecting even numbers
    Then  the result of add these numbers should be 15