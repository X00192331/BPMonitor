using TechTalk.SpecFlow;
using BPCalculator;
using FluentAssertions;

namespace BDDSpecFlow1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly BloodPressure _bloodPressure = new BloodPressure();
        private BPCategory _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the Systolic number is (.*)")]
        public void GivenTheSystolicNumberIs(int systolic)
        {
            _bloodPressure.Systolic = systolic;
        }

        [Given(@"the Diastolic number is (.*)")]
        public void GivenTheDiastolicNumberIs(int diastolic)
        {
            _bloodPressure.Diastolic = diastolic;
        }

        [When(@"the BPCategory is calculated")]
        public void WhenTheBPCategoryIsCalculated()
        {
            _result = _bloodPressure.Category;
        }


        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(BPCategory result)
        {
            //TODO: implement assert (verification) logic

            _result.Should().Be(result);
        }
    }
}
