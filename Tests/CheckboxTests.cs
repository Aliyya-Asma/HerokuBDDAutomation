using NUnit.Framework;
using OpenQA.Selenium;
using HerokuTests.Drivers;
using HerokuTests.Pages;
using OpenQA.Selenium.Support.UI;
namespace HerokuTests.Tests
{
    public class CheckboxTests
    { private CheckboxPage checkboxPage;
      private IWebDriver driver;
        private WebDriverWait wait;
        [SetUp]
        public void Setup()
        {
            driver = WebDriverFactory.CreateEdgeDriver();
            checkboxPage = new CheckboxPage(driver);
            wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(60));
        }
        [Test]
        public void CheckboxSelectionTest()
        {
            checkboxPage.GoTo();
            wait.Until(driver => driver.FindElements(By.CssSelector("input[type='checkbox']")).Count > 0);
            //Testing checkbox at index 0
            checkboxPage.CheckCheckbox(0);
            Assert.IsTrue(checkboxPage.IsCheckboxChecked(0), "Checkbox should be selected");
            checkboxPage.UnCheckCheckbox(0);
            Assert.IsFalse(checkboxPage.IsCheckboxChecked(0), "Checkbox should be deselected");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
