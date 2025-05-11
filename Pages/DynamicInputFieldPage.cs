using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
namespace HerokuTests.Pages
{
    public class DynamicInputFieldPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public DynamicInputFieldPage(IWebDriver driver) 
        { this.driver = driver;
          wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        private By inputField = By.XPath("//input[@type='text']");
        private By enableButton = By.XPath("//button[text()= 'Enable']");
        public void GoToDynamicControlsPage()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");
        }
        public void ClickEnableButton()
        {
            driver.FindElement(enableButton).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(inputField));
        }
        public bool VerifyIfTextBoxIsEnabled()
        {
            IWebElement inputElement = driver.FindElement(inputField);
            return inputElement.Enabled;
            //returns true if input element is enabled
        }
    }
}
