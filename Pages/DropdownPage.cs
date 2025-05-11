using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace HerokuTests.Pages
{
    public class DropdownPage
    {
        private IWebDriver driver;
        public DropdownPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private By dropdown = By.Id("dropdown");
        public void GoTo()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
        }
        public List<string> GetDropdownOptions()
        {
            var selectElement = new SelectElement(driver.FindElement(dropdown));
            return selectElement.Options.Select(option => option.Text).ToList();
        }
    }
}
