using System;
using TechTalk.SpecFlow;

namespace SpecFlowIntro.Steps
{
    [Binding]
    public class CalculatorStepDefinitions
    {

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine(number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            Console.WriteLine("Pressed Add Button");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            if (result == 120)
            {
                Console.WriteLine("The Test Passed");
            }
            else
            {
                Console.WriteLine("The Test Failed");
            }
        }
    }
}
