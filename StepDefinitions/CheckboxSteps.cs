using System;
using HerokuTests.Drivers;
using HerokuTests.Pages;
using HerokuTests.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
namespace HerokuTests.StepDefinitions
{
    [Binding]
    public class CheckboxSteps:BaseSteps
    {
        private CheckboxPage checkboxPage;
        private WebDriverWait wait;
        [Given("I am on the checkbox page")]
        public void GivenIAmOnTheCheckboxPage()
        {
            try
            {
                driver = WebDriverFactory.CreateEdgeDriver();
                checkboxPage = new CheckboxPage(driver);
                wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(60));
                checkboxPage.GoTo();
                wait.Until(driver => driver.FindElements(By.CssSelector("input[type='checkbox']")).Count > 0);// Your step implementation here
                Hooks.step.Pass("Navigated to Checkbox page successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to navigate to checkbox page: {ex.Message}");
                throw;
            }
        }
        [When("I check checkbox")]
        public void WhenICheckCheckbox()
        {
            try
            {
                checkboxPage.CheckCheckbox(0);
                Hooks.step.Pass("Checked the checkbox successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to check the checkbox: {ex.Message}");
                throw;
            }
        }
        [When("I uncheck checkbox")]
        public void WhenIUncheckCheckbox()
        {
            try
            {
                checkboxPage.UnCheckCheckbox(0);
                Hooks.step.Pass("Unchecked the checkbox successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to uncheck the checkbox: {ex.Message}");
                throw;
            }
        }
        [Then("checkbox should get selected")]
        public void ThenCheckboxShouldGetSelected()
        {
            try
            {
                Assert.IsTrue(checkboxPage.IsCheckboxChecked(0));
                Hooks.step.Pass("Checkbox got selected successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to select the checkbox: {ex.Message}");
                throw;
            }
        }
        [Then("checkbox should be deselected")]
        public void ThenCheckboxShouldBeDeselected()
        {
            try
            {
                Assert.IsFalse(checkboxPage.IsCheckboxChecked(0));
                Hooks.step.Pass("Checkbox got deselected successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to deselect the checkbox: {ex.Message}");
                throw;
            }
        }
    }
}
