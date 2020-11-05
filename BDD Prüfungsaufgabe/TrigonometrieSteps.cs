using System;
using TechTalk.SpecFlow;
using Xunit;

namespace BDD_Prüfungsaufgabe
{
    [Binding]
    public class TrigonometrieSteps
    {
        double number;
        [Given(@"the first number is Pi")]
        public void GivenTheFirstNumberIsPi()
        {
            number = Math.PI;
        }
        
        [When(@"sinus is taken")]
        public void WhenSinusIsTaken()
        {
            number = Math.Sin(number);
        }
        
        [When(@"cosinus is taken")]
        public void WhenCosinusIsTaken()
        {
            number = Math.Cos(number);
        }
        
        [When(@"tangens is taken")]
        public void WhenTangensIsTaken()
        {
            number = Math.Tan(number);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, number, 5);
        }
    }
}
