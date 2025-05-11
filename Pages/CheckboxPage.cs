using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
namespace HerokuTests.Pages
{
    public class CheckboxPage
    {
        private IWebDriver driver;
        public CheckboxPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private By checkboxes = By.CssSelector("input[type='checkbox']");
        public void GoTo()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");
        }
        public IWebElement GetCheckbox(int index)
        {
            return driver.FindElements(checkboxes)[index];
        }
        public void CheckCheckbox(int index)
        {
            var checkbox = GetCheckbox(index);
            if (!checkbox.Selected)
            {
                checkbox.Click();
            }
        }
        public void UnCheckCheckbox(int index)
        {
            var checkbox = GetCheckbox(index);
            if (checkbox.Selected)
            {
                checkbox.Click();
            }
        }
        public bool IsCheckboxChecked(int index)
        {
            var Checkbox = GetCheckbox(index);
            return Checkbox.Selected;
        }
    }
}
