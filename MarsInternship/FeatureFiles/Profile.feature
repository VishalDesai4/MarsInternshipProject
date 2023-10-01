Feature: Profile

 Check the log in functionlity for the mars project with valida inputs

@Regression
Scenario: [Check the log in functionlity for the mars project with valid username and password]
	Given [User enters desaivis@gmail.com as username and testmarslogin as password]
	When  [Click on log in button]
	Then  [User should have log in succesfully]

	@Regression
Scenario: [Check the log in functionlity for the mars project with valid username and invaliad password]
	Given [User enters desaivis@gmail.com as username and testmarslogin as password]
	When  [Click on log in button]
	Then  [User should have not log in and receive a message for invalid username]

	@Regression
Scenario: [Check the log in functionlity for the mars project with Invalid username and valiad password]
	Given [User enters desaivis@gmail.com as username and testmarslogin as password]
	When  [Click on log in button]
	Then  [User should have log in succesfully]

	@Regression
Scenario: [Check the log in functionlity for the mars project with Invalid username and Invaliad password]
	Given [User enters desaivis@gmail.com as username and testmarslogin as password]
	When [Click on log in button]
	Then [User should have log in succesfully]



