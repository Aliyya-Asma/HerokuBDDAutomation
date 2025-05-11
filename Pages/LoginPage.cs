using OpenQA.Selenium;
namespace HerokuTests.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private By usernameField = By.Id("username");
        private By passwordField = By.Id("password");
        private By loginButton = By.CssSelector("button[type='submit'");
        public void EnterUsername(string username)
        {
            driver.FindElement(usernameField).SendKeys(username);
        }
        public void EnterPassword(string password)
        {            
            driver.FindElement(passwordField).SendKeys(password);
        }
        public void ClickLogin()
        {
            driver.FindElement(loginButton).Click();
        }
    }
}
