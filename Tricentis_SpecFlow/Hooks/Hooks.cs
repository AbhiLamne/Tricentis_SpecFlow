using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Tricentis_SpecFlow.Drivers;

namespace Tricentis_SpecFlow.Hooks
{
    [Binding]
    public class Hooks
    {
        private IObjectContainer objectContainer;

        private IWebDriver dr;

        private static ExtentReports extent;
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ParallelConfig parallelconfig;

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }


        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Abhishek Lamne\source\repos\Tricentis\Tricentis_SpecFlow\Extent_Report\report.html");
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host", "Abhishek");
            extent.AddSystemInfo("Environment", "QA");
            
        }


        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            featureName = extent.CreateTest(context.FeatureInfo.Title);
        }


        [BeforeScenario]
        public void LaunchBrowser(ScenarioContext context)
        {
            dr = new ChromeDriver();
            objectContainer.RegisterInstanceAs<IWebDriver>(dr);

            scenario = featureName.CreateNode(context.ScenarioInfo.Title);
           
        }

        public MediaEntityModelProvider CaptureScreenshot(string Name)
        {
            var screenshot = ((ITakesScreenshot)dr).GetScreenshot().AsBase64EncodedString;

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, Name).Build();

        }


        [AfterStep]
        public void ReportingSteps(ScenarioContext context)
        {
            if (context.TestError == null)
            {
                scenario.Pass(context.StepContext.StepInfo.Text);

            }
            else if (context.TestError != null)
            {
                var mediaEntity = CaptureScreenshot(context.ScenarioInfo.Title.Trim());
                scenario.Fail(context.StepContext.StepInfo.Text, mediaEntity);             
            }

            if (context.ScenarioExecutionStatus.ToString() == "StepDefinationPending")
            {
                scenario.Skip(context.StepContext.StepInfo.Text);
            }
        }


        [AfterScenario]
        public void AfterScenario()
        {
            dr.Quit();
        }


        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }  
    }
}
