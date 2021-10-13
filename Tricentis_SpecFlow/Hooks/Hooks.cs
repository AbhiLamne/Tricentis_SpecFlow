using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

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
 

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }


        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Abhishek Lamne\source\repos\Tricentis\Tricentis_SpecFlow\Extent_Report");
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
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



        [AfterStep]
        public void ReportingSteps(ScenarioContext context)
        {
   
            if (context.TestError == null)
            {
                scenario.Log(Status.Pass, context.StepContext.StepInfo.Text);
                
            }
            else if (context.TestError != null)
            {
                scenario.Log(Status.Fail, context.StepContext.StepInfo.Text);             
            }

            if (context.ScenarioExecutionStatus.ToString() == "StepDefinationPending")
            {
                scenario.Log(Status.Skip, context.StepContext.StepInfo.Text);
            }
        }


        [AfterScenario]
        public void AfterScenario()
        {
           
        }


        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }  
    }
}
