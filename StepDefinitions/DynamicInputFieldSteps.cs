using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuTests.Drivers;
using HerokuTests.Pages;
using HerokuTests.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
namespace HerokuTests.StepDefinitions
{
    [Binding]
    public class DynamicInputFieldSteps:BaseSteps
    {
        DynamicInputFieldPage inputFieldpage;
        public DynamicInputFieldSteps() { }
        [Given("I am on Dynamic Controls page")]
        public void GivenIAmOnDynamicControlsPage() 
        {
            try
            {
                driver = WebDriverFactory.CreateEdgeDriver();
                inputFieldpage = new DynamicInputFieldPage(driver);
                inputFieldpage.GoToDynamicControlsPage();
                Hooks.step.Pass("Navigated to the dynamic controls page successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to navigate to the dynamic controls page : {ex.Message}");
                throw;
            }
        }
        [When("I click on Enable button")]
        public void WhenIClickOnEnableButton()
        {
            try
            {
                inputFieldpage.ClickEnableButton();
                Hooks.step.Pass("Clicked on enable button successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to click on enable button: {ex.Message}");
                throw;
            }
        }
        [Then("the input field must be Enabled")]
        public void ThenTheInputFieldMustBeEnabled()
        {
            Assert.IsTrue(inputFieldpage.VerifyIfTextBoxIsEnabled());
            try
            {
                // Your step implementation here
                Hooks.step.Pass("Input field enabled successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to enable Input field: {ex.Message}");
                throw;
            }
        }
    }
}
