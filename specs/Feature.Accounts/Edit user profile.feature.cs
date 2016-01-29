﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class EditUserProfileFeature : Xunit.IClassFixture<EditUserProfileFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Edit user profile.feature"
#line hidden
        
        public EditUserProfileFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Edit user profile", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(EditUserProfileFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Edit user profile")]
        [Xunit.TraitAttribute("Description", "Account_Edit user profile_UC1_Open Edit Profile page")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Account_EditUserProfile_UC1_OpenEditProfilePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Edit user profile_UC1_Open Edit Profile page", new string[] {
                        "NeedImplementation"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("User was registered and logged to Habitat", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.And("User clicks Edit Profile from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.Then("Edit Profile title presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.And("Page URL ends on /Edit Profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Edit user profile")]
        [Xunit.TraitAttribute("Description", "Account_Edit user profile_UC2_Update all fields_First time")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void Account_EditUserProfile_UC2_UpdateAllFields_FirstTime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Edit user profile_UC2_Update all fields_First time", new string[] {
                        "InDesign"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table1.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 14
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table1, "Given ");
#line 17
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number"});
            table2.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333"});
#line 18
 testRunner.When("User inputs data in to the fields", ((string)(null)), table2, "When ");
#line 21
 testRunner.And("User selects <Swiming> from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("User opens Sitecore by Admin user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("User opens User Manager", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("User clicks on <kov@sitecore.net> in user names list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("User presses Edit button on the ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("User selects Profile tab on Edit User popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number",
                        "Interests"});
            table3.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 28
 testRunner.Then("Following User info presents", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Edit user profile")]
        [Xunit.TraitAttribute("Description", "Account_Edit user profile_UC3_Update all fields_Change user info")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void Account_EditUserProfile_UC3_UpdateAllFields_ChangeUserInfo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Edit user profile_UC3_Update all fields_Change user info", new string[] {
                        "InDesign"});
#line 33
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number",
                        "Interests"});
            table4.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 34
 testRunner.Given("Habitat user was created and updated with following info", ((string)(null)), table4, "Given ");
#line 37
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number"});
            table5.AddRow(new string[] {
                        "Maximov",
                        "Stas",
                        "+38(067)8888888"});
#line 38
 testRunner.When("User inputs data in to the fields", ((string)(null)), table5, "When ");
#line 41
 testRunner.And("User selects <Skiing> from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("User opens Sitecore by Admin user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("User opens User Manager", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("User clicks on <kov@sitecore.net> in user names list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("User presses Edit button on the ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("User selects Profile tab on Edit User popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number",
                        "Interests"});
            table6.AddRow(new string[] {
                        "Maximov",
                        "Stas",
                        "+38(067)8888888",
                        "Skiing"});
#line 48
 testRunner.Then("Following User info presents", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Edit user profile")]
        [Xunit.TraitAttribute("Description", "Account_Edit user profile_UC4_Update one of the fields_First time")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void Account_EditUserProfile_UC4_UpdateOneOfTheFields_FirstTime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Edit user profile_UC4_Update one of the fields_First time", new string[] {
                        "InDesign"});
#line 54
this.ScenarioSetup(scenarioInfo);
#line 55
 testRunner.Given("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name"});
            table7.AddRow(new string[] {
                        "Teltov"});
#line 56
 testRunner.When("User inputs data in to the fields", ((string)(null)), table7, "When ");
#line 59
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("User opens Sitecore by Admin user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("User opens User Manager", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("User clicks on <kov@sitecore.net> in user names list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("User presses Edit button on the ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("User selects Profile tab on Edit User popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name"});
            table8.AddRow(new string[] {
                        "Teltov"});
#line 65
 testRunner.Then("Following User info presents", ((string)(null)), table8, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "First Name",
                        "Phone number",
                        "Interests"});
            table9.AddRow(new string[] {
                        "empty",
                        "empty",
                        "empty"});
#line 68
  testRunner.And("Following user info absents", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Edit user profile")]
        [Xunit.TraitAttribute("Description", "Account_Edit user profile_UC5_Update one of the fields_Change user info")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void Account_EditUserProfile_UC5_UpdateOneOfTheFields_ChangeUserInfo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Edit user profile_UC5_Update one of the fields_Change user info", new string[] {
                        "InDesign"});
#line 74
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number",
                        "Interests"});
            table10.AddRow(new string[] {
                        "Teltov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 75
 testRunner.Given("Habitat user was created and updated with following info", ((string)(null)), table10, "Given ");
#line 78
 testRunner.And("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name"});
            table11.AddRow(new string[] {
                        "Maximov"});
#line 79
 testRunner.When("User inputs data in to the fields", ((string)(null)), table11, "When ");
#line 82
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("User opens Sitecore by Admin user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("User opens User Manager", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("User clicks on <kov@sitecore.net> in user names list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("User presses Edit button on the ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("User selects Profile tab on Edit User popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last Name",
                        "First Name",
                        "Phone number",
                        "Interests"});
            table12.AddRow(new string[] {
                        "Maximov",
                        "Konstantin",
                        "+38(067)3333333",
                        "Swiming"});
#line 88
 testRunner.Then("Following User info presents", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Edit user profile")]
        [Xunit.TraitAttribute("Description", "Account_Edit user profile_UC6_Phone validation_Two plus symbols in the begining")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void Account_EditUserProfile_UC6_PhoneValidation_TwoPlusSymbolsInTheBegining()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Edit user profile_UC6_Phone validation_Two plus symbols in the begining", new string[] {
                        "InDesign"});
#line 94
this.ScenarioSetup(scenarioInfo);
#line 95
 testRunner.Given("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Phone number"});
            table13.AddRow(new string[] {
                        "++380673333333"});
#line 96
 testRunner.When("User inputs data in to the fields", ((string)(null)), table13, "When ");
#line 99
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Error message"});
            table14.AddRow(new string[] {
                        "Phone number should contain only +, ( ) and digits"});
#line 100
 testRunner.Then("System shows following error message for the Edit Profile", ((string)(null)), table14, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Edit user profile")]
        [Xunit.TraitAttribute("Description", "Account_Edit user profile_UC6_Phone validation_Brackets without number")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void Account_EditUserProfile_UC6_PhoneValidation_BracketsWithoutNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Edit user profile_UC6_Phone validation_Brackets without number", new string[] {
                        "InDesign"});
#line 105
this.ScenarioSetup(scenarioInfo);
#line 106
 testRunner.Given("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Phone number"});
            table15.AddRow(new string[] {
                        "+()380673333333"});
#line 107
 testRunner.When("User inputs data in to the fields", ((string)(null)), table15, "When ");
#line 110
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Error message"});
            table16.AddRow(new string[] {
                        "Phone number should contain only +, ( ) and digits"});
#line 111
 testRunner.Then("System shows following error message for the Edit Profile", ((string)(null)), table16, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Edit user profile")]
        [Xunit.TraitAttribute("Description", "Account_Edit user profile_UC6_Phone validation_Digits in phone field")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void Account_EditUserProfile_UC6_PhoneValidation_DigitsInPhoneField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Edit user profile_UC6_Phone validation_Digits in phone field", new string[] {
                        "InDesign"});
#line 117
this.ScenarioSetup(scenarioInfo);
#line 118
 testRunner.Given("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Phone number"});
            table17.AddRow(new string[] {
                        "+38067Kostia"});
#line 119
 testRunner.When("User inputs data in to the fields", ((string)(null)), table17, "When ");
#line 122
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Error message"});
            table18.AddRow(new string[] {
                        "Phone number should contain only +, ( ) and digits"});
#line 123
 testRunner.Then("System shows following error message for the Edit Profile", ((string)(null)), table18, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Edit user profile")]
        [Xunit.TraitAttribute("Description", "Account_Edit user profile_UC6_Phone validation_Phone number lenght should be less" +
            " than 20")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void Account_EditUserProfile_UC6_PhoneValidation_PhoneNumberLenghtShouldBeLessThan20()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Edit user profile_UC6_Phone validation_Phone number lenght should be less" +
                    " than 20", new string[] {
                        "InDesign"});
#line 129
this.ScenarioSetup(scenarioInfo);
#line 130
 testRunner.Given("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Phone number"});
            table19.AddRow(new string[] {
                        "+38067333333333333331"});
#line 131
 testRunner.When("User inputs data in to the fields", ((string)(null)), table19, "When ");
#line 134
 testRunner.And("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Error message"});
            table20.AddRow(new string[] {
                        "Phone number lenght should be less than 20"});
#line 135
 testRunner.Then("System shows following error message for the Edit Profile", ((string)(null)), table20, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Edit user profile")]
        [Xunit.TraitAttribute("Description", "Account_Edit user profile_UC7_Empty user profile is saved")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void Account_EditUserProfile_UC7_EmptyUserProfileIsSaved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Edit user profile_UC7_Empty user profile is saved", new string[] {
                        "InDesign"});
#line 141
this.ScenarioSetup(scenarioInfo);
#line 142
 testRunner.Given("Habitat website is opened on Edit Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 143
 testRunner.When("User clicks Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 144
 testRunner.And("User opens Sitecore by Admin user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.And("User opens User Manager", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.And("User clicks on <kov@sitecore.net> in user names list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
 testRunner.And("User presses Edit button on the ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.And("User selects Profile tab on Edit User popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.Then("No any user profile fields present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                EditUserProfileFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                EditUserProfileFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
