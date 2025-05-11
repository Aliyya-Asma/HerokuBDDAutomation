Feature: Dropdown
Dropdown options verification
Scenario: Verify dropdown options
    Given I have navigated to the dropdown page
    When I retrieve the dropdown options
    Then the options should be:
  |Options|
  | Please select an option |
  | Option 1                |
  | Option 2                |