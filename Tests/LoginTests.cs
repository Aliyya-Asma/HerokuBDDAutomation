using NUnit.Framework;
using OpenQA.Selenium;
using HerokuTests.Drivers;
using HerokuTests.Pages;
namespace HerokuTests.Tests
{
    public class LoginTests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = WebDriverFactory.CreateEdgeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
        }
        [Test]
        public void SuccessfulLoginTest()
        {
            var loginPage = new LoginPage(driver);
            loginPage.EnterUsername("tomsmith");
            loginPage.EnterPassword("SuperSecretPassword!");
            loginPage.ClickLogin();
            string message = driver.FindElement(By.Id("flash")).Text;
            Assert.That(message.Contains("You logged into a secure area!"));
        }
        [Test]
        public void UnsuccessfulLoginTest()
        {
            var loginPage = new LoginPage(driver);
            loginPage.EnterUsername("aliyya");
            loginPage.EnterPassword("aliyya123");
            loginPage.ClickLogin();
            string message = driver.FindElement(By.CssSelector(".flash.error")).Text;
            Assert.That(message.Contains("Your username is invalid!"));
        }
        [TearDown]
        public void TearDown()
        {
        driver.Quit();
        }
    }
}
