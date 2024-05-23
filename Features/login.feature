﻿Feature: Test users login

Verify login feature for the application

@SmokeTest1
Scenario: Verify that is not able to login with invalid credentials
	Given User enters 'username' and 'password'
	When User clicks on login
	Then Response should be false

@SmokeTest2
Scenario: Verify that user is able to login with valid credentials
	Given User enters 'Aravindan' and 'Kaiv'
	When User clicks on login
	Then Response should be True
