using System;
using TechTalk.SpecFlow;

namespace AutoTestFramework.specs.Steps
{
    [Binding]
    public class EndToEndAutomationTestSteps
    {
        [Given(@"I navigate to Ebay\.com\.au")]
        public void GivenINavigateToEbay_Com_Au()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I navigate to the Sign In Page")]
        public void WhenINavigateToTheSignInPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I log in as a valid user")]
        public void WhenILogInAsAValidUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search for the following items using the Search bar")]
        public void WhenISearchForTheFollowingItemsUsingTheSearchBar(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select the desired Product")]
        public void WhenISelectTheDesiredProduct()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Add to Cart button next to the selected item")]
        public void WhenIClickOnAddToCartButtonNextToTheSelectedItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The search results are displayed")]
        public void ThenTheSearchResultsAreDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The Product Detail page is displayed")]
        public void ThenTheProductDetailPageIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The Shopping Cart is displayed")]
        public void ThenTheShoppingCartIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I verify that the Selected Item is present in the Cart")]
        public void ThenIVerifyThatTheSelectedItemIsPresentInTheCart()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
