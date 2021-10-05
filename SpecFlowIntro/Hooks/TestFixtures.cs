using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowIntro.Hooks
{
    [Binding]
    public sealed class TestFixtures
    {
        [BeforeFeature]
        public static void beforefeaturestep()
        {
            Console.WriteLine("Before Test Feature");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Before Test Scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After Test Scenario");
        }
    }
}
