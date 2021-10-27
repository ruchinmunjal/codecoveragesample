using System;
using Xunit;
using App.BusinessLogic;

namespace Test.BusinessLogic
{
    public class UnitTest1
    {
        private readonly Calculator _calculator = new Calculator();
        [Fact]
        public void GivenTwoNumbers_Add_ReturnsTheTwoNumbersAddedTogether()
        {
            var one = 1;
            var two = 2;
            var actual = _calculator.Add(one, two);
            Assert.Equal(3, actual);
        }

        [Fact]
        public void GivenTwoNumbers_Subtract_ReturnsTheFirstNumberSubtractedFromTheSecond()
        {
            var one = 1;
            var two = 2;
            var actual = _calculator.Subtract(one, two);
            Assert.Equal(-1, actual);
        }
    }
}
