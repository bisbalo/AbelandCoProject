Feature: Order
	To be able to order items on AbelandCole's Website

@mytag
Scenario: Ordering from AbelandCole's Website 
	Given I navigate to the website "https://www.abelandcole.co.uk/"
	And i click on accept cookies
	And in the search field i enter " Salted Brownie Tray organic Daylesford"
	And i click on the search logo
	And i click on saltedimage button
	And i click on Add salted button
    And i enter popcorn into the search field"Simply popcorn organic"
	And i click on search logo
	And i click on salted popcorn image
	And i  click on Add popcornbutton
	And i enter hummus in the search field "Hummus Chips Organic Eat Real"
	And i click on Search  Huumus logo 
	And i click on Add Button for Hummus Chips
	And i  add  Two packs of  "oats crumbles organic bakery"
	Then i should be able to have Twelve items in my basket




	
	