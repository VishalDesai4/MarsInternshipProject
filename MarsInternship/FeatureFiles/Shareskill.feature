Feature: Shareskill

Sign In functionality for Mars project

@Authentication1
Scenario: [Succesfull Sign In with valid credential]
	Given [I am on the log in page ]
	And [I enter valid username and password]
	When [I click on the log in button]
	Then [I shoud be able to sign in succesfully ]
	
@Authentication2
Scenario: [Verify invalid username]
	Given [I am on the log in page]
	And [I enter Invalid username and valid password]
	When [click on the log in button]
	Then [I should be able to see link  "send verification email"]

@Authentication3
Scenario: [Verify invalid password]
	Given [I am on the log in page]
	And [I enter valid username and invalid password]
	When [click on the log in button]
	Then [I should be able to see  link  "send verification email"]

	@Authentication4
Scenario: [Verify invalid username and password]
	Given [I am on the log in page]
	And [I enter Invalid username and invalid password]
	When [click on the log in button]
	Then [I should be able to see  link  "send verification email"]

	@ProfileSelection
Scenario: [select preferences in profile and save them]
	Given [I am on profile page]
	And [I Click on "edit button" on availability section ]
	And [Click on "drop down" button ]
	And [select "part time" option]
	And [ I Click on "edit button" on hours section]
	And [click on "drop down" button ]
	And [click on "As needed" option]
	And [Click on "edit button" on hours section 
	And [click on "drop down" button ]
	And [Click on "more than 1000 per month" option
	When [Click on save button]
	Then [I should be able to save my all preferences in profile]

	@Loadtest
Scenario: [Entering Description with max words]
	Given [I am on the profile page]
	And [Click on edit button of description]
	When [When I write 601 words]
	Then [variable "character remaining" shows number 0 and not able to write further

	@language1
Scenario: [Adding max four language]
	Given [	I am on profile page ] 
	And [click on " add new button"]
	And [write FIRSTlanguage that you know in language field]
	And [ click pull down menu]
	And [select level of language]
	When [click save button]
	Then [I should be able to see four language raw that has been added and fifth one dont allow as adding feature become unavailable]
	Examples: 
	| English  |
	| Hindi    |
	| Gujarati |
	| Arabic   |



	Scenario: [Edit and Updating language]
	Given [	I am on profile page ] 
	And [Click on edit button]
	And [ click pull down menu]
	And [select level of language]
	When [click update button]
	Then [I should be able to see message for language has been uddated]

	Scenario: [delete language]
	Given [	I am on profile page ] 
	When [click delet button]
	Then [I should be able to message for language has bee deleted]

	@tag1
Scenario: [scenario name]
	Given [context]
	When [action]
	Then [outcome]

	@tag1
Scenario: [scenario name]
	Given [context]
	When [action]
	Then [outcome]
