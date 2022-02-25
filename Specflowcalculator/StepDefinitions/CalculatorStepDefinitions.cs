using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.FirstNumber - _calculator.SecondNumber;
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.FirstNumber * _calculator.SecondNumber;
        }

        [When(@"operation \+ is done to the number (.*)")]
        public void WhenOperationPlusIsDoneToTheNumber(int p0)
        {
            _result = _calculator.FirstNumber + p0;
            _calculator.FirstNumber = _result;
        }

        [When(@"operation / is done to the number (.*)")]
        public void WhenOperationDivideIsDoneToTheNumber(int p0)
        {
            _result = _calculator.FirstNumber / p0;
            _calculator.FirstNumber = _result;
        }

        [When(@"operation - is done to the number (.*)")]
        public void WhenOperation_IsDoneToTheNumber(int p0)
        {
            _result = _calculator.FirstNumber - p0;
            _calculator.FirstNumber = _result;
        }

        [When(@"operation % is done to the number (.*)")]
        public void WhenOperationIsDoneToTheNumber(int p0)
        {
            _result = _calculator.FirstNumber % p0;
            _calculator.FirstNumber = _result;

        }


    }
}