Feature: LogOut
	In order to login in NewBookModels
	As a client of NewBookModels
	I want to be logouted from NewBookModels

@mytag
Scenario:  It is possible to logout in NewBookModels 
Given I login, using API 
	When I click the link 
	Then I successfully logouted in NewBookModels as  client
