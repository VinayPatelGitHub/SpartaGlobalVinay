using System;
using TechTalk.SpecFlow;
using Calculator;
using NUnit.Framework;

namespace SpecFlowExample
{
    [Binding]
    public class CalculatorSteps
    {
        private int _resultAdd { get; set; }
        private int _resultSubract { get; set; }

        private int _resultAddEvenNumberinList { get; set; }

        //1st Scenario:
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number1)
        {
            Calc.Number1 = number1;
        }
        
        [Given(@"then I enter (.*) into the calculator")]
        public void GivenThenIEnterIntoTheCalculator(int number2)
        {
            Calc.Number2 = number2;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _resultAdd = Calc.Add();
        }
        
        [Then(@"as the result of adding the screen should show (.*)")]
        public void ThenAsTheResultOfAddingTheScreenShouldShow(int expected)
        {
            Assert.That(_resultAdd, Is.EqualTo(expected));

        }

        //2nd Scenario:
        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _resultSubract = Calc.Subtract();
        }

        [Then(@"as the result of subtracting the screen should show (.*)")]
        public void ThenAsTheResultOfSubtractingTheScreenShouldShow(int expected)
        {
            Assert.That(_resultSubract, Is.EqualTo(expected));            
        }

        //3rd Scenario:
        [Given(@"I have entered the numbers below to a list")]
        public void GivenIHaveEnteredTheNumbersBelowToAList(Table table)
        {
            Calc.TableofNumbers = table;
        }

        [When(@"I iterate through the list, selecting even numbers")]
        public void WhenIIterateThroughTheListSelectingEvenNumbers()
        {
            Calc.IterateThroughTheListSelectingEvenNumbers();
        }

        [Then(@"the result of add these numbers should be (.*)")]
        public void ThenTheResultOfAddTheseNumbersShouldBe(int expected)
        {
            _resultAddEvenNumberinList = Calc.AddEvenNumberinList();
            Assert.That(_resultAddEvenNumberinList, Is.EqualTo(expected));
        }


    }
}
