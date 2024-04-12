Feature: Test user login

  @SCRUM-2 @OPEN
  Scenario: Verify that is not able to login with invalid credentials
    Given User enters 'username' and 'password'
    When User clicks on login
    Then Response should be 'false'
    And Logged in Successfully
