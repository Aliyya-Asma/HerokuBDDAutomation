using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
namespace HerokuTests.Drivers
{
   public class WebDriverFactory
    { 
        public static IWebDriver CreateEdgeDriver()
        {
            var options = new EdgeOptions();
            options.AddArgument("start-maximized");
            return new EdgeDriver(options);
        }
    }
}
