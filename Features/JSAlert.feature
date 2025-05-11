Feature: JS Alert
To verify JS Alert text
Background: 
          Given I am on JS Alerts page
Scenario: JS Alert Text verification
          When I Click on JS Alert button
          Then an alert opens with text 'I am a JS Alert'