Feature: End to End Automation Test
	The test consists in searching for 2 different products, add them in the shopping cart and validate if the shopping cart contains the selected products
	
	Background:
		Given I navigate to Ebay.com.au
	
	@endtoendautomation
	Scenario Outline: Search for 2 Different Products and Add them to Shopping Cart
		When I navigate to the Sign In Page
		And I log in as a valid user
		When I search for the following items using the Search bar
			|product	|
			|<product>	|
		Then The search results are displayed
		When I select the desired Product 
		Then The Product Detail page is displayed
		When I click on Add to Cart button next to the selected item
		Then The Shopping Cart is displayed
		And I verify that the Selected Item is present in the Cart
	
	Examples:
			|product				|
			|phillips air fryer		|
			|phillips hair dryer	|