Feature: Registration
Feature: Login
	In order to registration in NewBookModels
	As a client of NewBookModels
	I want to be registered in NewBookModels

@mytag
Scenario: It is possible to login in NewBookModels with valid data
	//Given Client is new
	Given Sign out page is opened
	When I input first name of a new client in First Name field
	And I input last name of a new client in Last Name field
	And I input email of a new client in Email field
	And I input password of a new client in Password  field
	And I input Confirm Password of a new client in Confirm Password  field
	And I input Mobile of a new client in Mobile field
	And I click Next button
	Then  I successfully registered in NewBookModels as new client
