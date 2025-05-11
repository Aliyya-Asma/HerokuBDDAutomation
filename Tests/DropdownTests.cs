using System.Collections.Generic;
using HerokuTests.Drivers;
using HerokuTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
namespace HerokuTests.Tests
{
    public class DropdownTests
    {
        private IWebDriver driver;
        DropdownPage dropdownPage;
        [SetUp]
        public void SetUp() 
        {
            driver = WebDriverFactory.CreateEdgeDriver();
            dropdownPage = new DropdownPage(driver);
            dropdownPage.GoTo();
        }
        [Test]
        public void DropdownOptionsTest()
        {
            List<string> options = dropdownPage.GetDropdownOptions();
            List<string> expected = new List<string> { "Please select an option", "Option 1", "Option 2" };
            CollectionAssert.AreEqual(expected, options);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
