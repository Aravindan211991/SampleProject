﻿Feature: Test user login

#Verify login feature for the application

@SmokeTest
Scenario: Verify that user is not able to login with invalid credentials
	Given User enters 'name' and 'pass'
	When User clicks on login
	Then Response should be 'False'

@SmokeTest2
Scenario: Verify that user is able to login with valid credentials
	Given User enters 'Aravindan' and 'Kaiv'
	When User clicks on login
	Then Response should be 'True'
