using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using HerokuTests.Drivers;
using HerokuTests.Pages;
namespace HerokuTests.Tests
{
    public class JSAlertTests
    {
        private IWebDriver driver;
        private JSAlertPage jsAlertPage;
        [SetUp]
        public void SetUp()
        {
            driver = WebDriverFactory.CreateEdgeDriver();
            jsAlertPage = new JSAlertPage(driver);
            jsAlertPage.GoToAlertPage();
        }
        [Test]
        public void VerifyAlertText()
        {
            string expectedAlertText = "I am a JS Alert";
            jsAlertPage.clickOnJSAlertButton();
            String actualAlertText = jsAlertPage.getAlertText();
            Assert.AreEqual(expectedAlertText, actualAlertText, "The alert text does not match the expected value.");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
