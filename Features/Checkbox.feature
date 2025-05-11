Feature: Checkbox Selection and Deselection
To Test Checkbox
Rule: Clicking on checkbox Selects it, clicking again deselects it
Background: 
    Given I am on the checkbox page
Scenario: Selection
	When I check checkbox
	Then checkbox should get selected
Scenario: Deselection
	When I uncheck checkbox
	Then checkbox should be deselected