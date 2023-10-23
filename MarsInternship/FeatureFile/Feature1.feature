Feature: Feature1

A short summary of the feature

@RegressionTest
@BrowserChrome
Scenario Outline: Verify if the log in functionality is working (+ Test)
	Given [I am on the log in page ]
	And [I enter valid  <username> and <password>
	When [I click on the log in button]
	Then [I shoud be able to sig n in succesfully ]
	| username           | password    |
	| desaivis@gmail.com | Hiya12345@  |
	| desaivis@gmail.com | Hiya12345@  |

@RegressionTest
Scenario Outline: Verify if the log in functionality gives error message (- Test)
	Given [I am navigating the log in page]
	And [I enter Invalid <username> and valid <password>]
	When [click on the log in button]
	Then [I should be able to get error message]
	| username | password  |
	| user1    | password1 |
	| user1    | password2 |
	| user2    | password1 |
		

	@AddingAndCancellanguage
Scenario: [Adding and cancel language]
	Given [	I navigate to profile page ] 
	When [Click on add new button]
	Then [Click on cancel to cancel it]



    @AddingMaximumFourLanguage
Scenario Outline: [Adding Maximum four Lanugage]
	Given [	I am on profile page ] 
	And   [Click on add new button]
	And   [ write language thats wants to ad]
	And  [select level of language as expert]
	When  [click  on add button]
	Then  [I should be able to see raw for language has been added]
	| Language |  | Language Level |
	| Hindi    |  | Skill Level |
	| Gujarati |  | Conversational|
	| English  |  | Fluent |
	| Arabic   |  | Basic |


	@deleteFunctionOnLanguage
Scenario: [delete language]
	Given [I will navigate to profile page ] 
	When  [click delet button]
	Then  [I should be able to message for language has bee deleted]

@EditCancelAndUpdateRecord
Scenario: [Edit, Cancel And Update Record]
	Given [I will navigate to profile page ] 
	And [Click on Edit record and Cancel record]
	When  [Edit rlanguage record and change level of proficiency]
	Then  [I should be able to upate record]




	@AddFeatureOfSkill
Scenario: [Adding skills ]
	Given [	I will click on profile page ] 
	And [click on " add new button"]
	And [write First skill that you have to share it]
	And [ click pull down menu]
	And [select level of skill]
	When [click add button]
	Then [I should be able to see skill that has been added]
	| Skill    |  | Level oF Skill |
	| Business |  | Expert         |
	| Cooking  |  | Intermediate   |

	@AddingAndCanceSkill
Scenario: [Adding and cancel Skill]
	Given [	I am on profile page ] 
	When [Click on add new  skill button]
	Then [Click on cancel button to cancel it]

	@EditCancelAndUpdateSkillRecord
Scenario: [Edit, Cancel And Update skill Record]
	Given [I will be navigate to profile page ] 
	And [Click on Edit button and Cancel record by cliking cancel]
	When  [Edit skill record and change level of  skill proficiency]
	Then  [I should be able to upate skill record]


	@DeleteFeatureOfSkill
Scenario: [Delete skills ]
	Given [I will naviagte to skill page ] 
	When  [click delete button on skill]
	Then  [I should be able delete skill raw]