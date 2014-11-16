Feature: MainVM
	In order to manage shared resources
	As an EMIS admin user
	I want to see my organisations folders

@mytag
Scenario: View root folder
	Given I am logged to the organisation named 'Test Org' 
	And the organisation has these concept folders
	| Name    | Id | ParentId |
	| Folder1 | 1  | -1       |
	When I open the resource manager 
	Then I should see a root folder named 'Test Org'