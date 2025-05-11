using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Reqnroll;
namespace HerokuTests.Utils
{
    [Binding]
    public class Hooks
    {
        private static ExtentReports extent;
        private static ExtentTest feature;
        private static ExtentTest scenario;
        public static ExtentTest step;
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            extent = ReportManager.GetInstance();
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            feature = extent.CreateTest(new GherkinKeyword("Feature"), featureContext.FeatureInfo.Title);
        }
        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            scenario = feature.CreateNode(new GherkinKeyword("Scenario"), scenarioContext.ScenarioInfo.Title);
            step = scenario;
        }
        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            var stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            var stepInfo = scenarioContext.StepContext.StepInfo.Text;
            step = scenario.CreateNode(new GherkinKeyword(stepType), stepInfo);
            if (scenarioContext.TestError != null)
            {
                step.Fail(scenarioContext.TestError.Message);
            }
            else
            {
                step.Pass("Step passed");
            }
        }
        [AfterScenario]
        public void AfterScenario()
        {
            extent.Flush();
        }
    }
}