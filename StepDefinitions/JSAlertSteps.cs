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
    public class JSAlertSteps:BaseSteps
    {
        private JSAlertPage jsAlertPage;
        [Given("I am on JS Alerts page")]
        public void GivenIAmOnJSAlertsPage()
        {
            try
            {
                driver = WebDriverFactory.CreateEdgeDriver();
                jsAlertPage = new JSAlertPage(driver);
                jsAlertPage.GoToAlertPage();
                Hooks.step.Pass("Navigated to the JS Alerts page successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to navigate to the JS Alerts page: {ex.Message}");
                throw;
            }
        }
        [When("I Click on JS Alert button")]
        public void WhenIClickOnJSAlertButton()
        {
            try
            {
                jsAlertPage.clickOnJSAlertButton();
                Hooks.step.Pass("Clicked on JS Alert button successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to click on JS Alert button: {ex.Message}");
                throw;
            }
        }
        [Then("an alert opens with text {string}")]
        public void ThenAnAlertOpensWithText(string expectedAlertText)
        {
            try
            {
                String actualAlertText = jsAlertPage.getAlertText();
                Assert.AreEqual(expectedAlertText, actualAlertText);
                Hooks.step.Pass("Alert text is verified successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to verify alert text: {ex.Message}");
                throw;
            }
        }
    }
}
