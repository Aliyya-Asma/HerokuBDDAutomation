using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Reqnroll;
namespace HerokuTests.StepDefinitions
{
    public class BaseSteps
    {
        protected IWebDriver driver;
        [AfterScenario]
        public void TearDown()
        {
            driver?.Quit();
        }
    }
}
