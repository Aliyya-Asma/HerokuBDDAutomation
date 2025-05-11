using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V134.Network;
namespace HerokuTests.Pages
{
    public class JSAlertPage
    {
        private IWebDriver driver;
        public JSAlertPage(IWebDriver driver)
        { this.driver = driver;
        }
        private By jsAlertButton = By.XPath("//button[text()= 'Click for JS Alert']");
        public void GoToAlertPage()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
        }
        public void clickOnJSAlertButton()
        {
            driver.FindElement(jsAlertButton).Click();
        }
        public String getAlertText()
        {
            IAlert alert = driver.SwitchTo().Alert();
            string text = alert.Text;
            alert.Accept();
            return text;
        }
    }
}
