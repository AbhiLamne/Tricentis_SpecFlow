using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Shouty.specs.StepDefinations
{
    [Binding]
    public class StepDefinations
    {

        [Given(@"Lucy is located (.*)m from Sean")]
        public void GivenLucyIsLocatedMFromSean(int distance)
        {
            var lucy = new Person();
            var sean = new Person();
            lucy.MoveTo(distance);
        }


        [When("Sean shouts {string}")]
        public void WhenSeanShouts(string p0)
        {
            throw new PendingStepException();
        }

        [Then("Lucy hears Sean's message")]
        public void ThenLucyHearsSeanSMessage()
        {
            throw new PendingStepException();
        }
    }
    
}
