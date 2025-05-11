using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using HerokuTests.Drivers;
using HerokuTests.Pages;
using HerokuTests.Utils;
using NUnit.Framework;
using Reqnroll;
namespace HerokuTests.StepDefinitions
{
    [Binding]
    public class DropdownSteps:BaseSteps
    {
        private DropdownPage dropdownPage;
        private List<string> options;
        [Given ("I have navigated to the dropdown page")]
        public void GivenIHaveNavigatedToTheDropdownPage()
        {
            try
            {
                driver = WebDriverFactory.CreateEdgeDriver();
                dropdownPage = new DropdownPage(driver);
                dropdownPage.GoTo();
                Hooks.step.Pass("Navigated to the dropdown page successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to navigate to the dropdown page: {ex.Message}");
                throw;
            }
        }
        [When ("I retrieve the dropdown options")]
        public void WhenIRetrieveTheDropdownOptions()
        {
            try
            {
                options = dropdownPage.GetDropdownOptions();
                Hooks.step.Pass("Retrieved the dropdown options successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to retrieve the dropdown options: {ex.Message}");
                throw;
            }
        }
        [Then (@"the options should be:")]
        public void ThenTheOptionsShouldBe(DataTable table)
        {
            try
            {
                List<string> expectedOptions = table.Rows.Select(row => row["Options"]).ToList();
                CollectionAssert.AreEqual(expectedOptions, options);
                Hooks.step.Pass("Verified the options successfully.");
            }
            catch (Exception ex)
            {
                Hooks.step.Fail($"Failed to verify the options: {ex.Message}");
                throw;
            }
        }
    }
}
