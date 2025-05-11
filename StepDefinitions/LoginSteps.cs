using HerokuTests.Drivers;
using HerokuTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using HerokuTests.Utils;
using System;
namespace HerokuTests.StepDefinitions
{
    [Binding]
    public class LoginSteps:BaseSteps
    {
        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            try
            {
                driver = WebDriverFactory.CreateEdgeDriver();
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
                Hooks.step.Pass("Navigated to the login page successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to navigate to the login page: {ex.Message}");
                throw;
            }
        }
        [When("I give valid credentials")]
        public void WhenIGiveValidCredentials()
        {
            try
            {
                var loginPage = new LoginPage(driver);
                loginPage.EnterUsername("tomsmith");
                loginPage.EnterPassword("SuperSecretPassword!");
                loginPage.ClickLogin();
                Hooks.step.Pass("Entered valid credentials successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to enter valid credentials: {ex.Message}");
                throw;
            }
        }
        [When("I give invalid credentials")]
        public void WhenIGiveInvalidCredentials()
        {
            try
            {
                var loginPage = new LoginPage(driver);
                loginPage.EnterUsername("aliyya");
                loginPage.EnterPassword("aliyya123");
                loginPage.ClickLogin();
                Hooks.step.Pass("Entered invalid credentials successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to enter invalid credentials: {ex.Message}");
                throw;
            }
        }
        [Then("I should see a success message")]
        public void ThenIShouldSeeASuccessMessage()
        {
            try
            {
                string message = driver.FindElement(By.Id("flash")).Text;
                Assert.That(message.Contains("You logged into a secure area!"));
                Hooks.step.Pass("Success message shown successfully");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to show success message: {ex.Message}");
                throw;
            }
        }
        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            try
            {
                string message = driver.FindElement(By.CssSelector(".flash.error")).Text;
                Assert.That(message.Contains("Your username is invalid!"));
                Hooks.step.Pass("Error message shown successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to show error message: {ex.Message}");
                throw;
            }
        }
    }
}
