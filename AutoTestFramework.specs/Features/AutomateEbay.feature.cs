﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutoTestFramework.specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("End to End Automation Test")]
    public partial class EndToEndAutomationTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AutomateEbay.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "End to End Automation Test", "\tThe test consists in searching for 2 different products, add them in the shoppin" +
                    "g cart and validate if the shopping cart contains the selected products", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
 #line 5
  testRunner.Given("I navigate to Ebay.com.au", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search for 2 Different Products and Add them to Shopping Cart")]
        [NUnit.Framework.CategoryAttribute("endtoendautomation")]
        [NUnit.Framework.TestCaseAttribute("phillips air fryer", null)]
        [NUnit.Framework.TestCaseAttribute("phillips hair dryer", null)]
        public virtual void SearchFor2DifferentProductsAndAddThemToShoppingCart(string product, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "endtoendautomation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for 2 Different Products and Add them to Shopping Cart", null, @__tags);
#line 8
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
 this.FeatureBackground();
#line 9
  testRunner.When("I navigate to the Sign In Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
  testRunner.And("I log in as a valid user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "product"});
            table1.AddRow(new string[] {
                        string.Format("{0}", product)});
#line 11
  testRunner.When("I search for the following items using the Search bar", ((string)(null)), table1, "When ");
#line 14
  testRunner.Then("The search results are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
  testRunner.When("I select the desired Product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
  testRunner.Then("The Product Detail page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
  testRunner.When("I click on Add to Cart button next to the selected item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
  testRunner.Then("The Shopping Cart is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
  testRunner.And("I verify that the Selected Item is present in the Cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
