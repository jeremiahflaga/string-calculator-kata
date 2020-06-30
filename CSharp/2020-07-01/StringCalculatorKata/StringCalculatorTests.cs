using System;
using Xunit;

namespace StringCalculatorKata
{
    public class StringCalculatorTests
    {
        [Fact]
        public void should_return_zero_for_empty_string()
        {
            var strCalc = new StringCalculator();
            var sum = strCalc.Add("");

            Assert.Equal(0, sum);
        }

        [Fact]
        public void should_return_1_for_1()
        {
            var strCalc = new StringCalculator();
            var sum = strCalc.Add("1");

            Assert.Equal(1, sum);
        }

        [Fact]
        public void should_return_2_for_2()
        {
            var strCalc = new StringCalculator();
            var sum = strCalc.Add("2");

            Assert.Equal(2, sum);
        }
    }
}
