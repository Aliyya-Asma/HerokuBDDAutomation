using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HerokuTests.Drivers;
using HerokuTests.Pages;
using OpenQA.Selenium;
namespace HerokuTests.Tests
{
    public class DynamicInputFieldTests
    {
        private IWebDriver driver;
        DynamicInputFieldPage inputFieldpage;
        [SetUp]
        public void SetUp()
        {
            driver = WebDriverFactory.CreateEdgeDriver();
            inputFieldpage = new DynamicInputFieldPage(driver);
            inputFieldpage.GoToDynamicControlsPage();
        }
        [Test]
        public void Test()
        {
            inputFieldpage.ClickEnableButton();
            Assert.IsTrue(inputFieldpage.VerifyIfTextBoxIsEnabled());
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
